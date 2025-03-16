using AutoService.Models.User;
using AutoService.Controllers;
using AutoService.Attributes;

namespace AutoService.Services
{
    public interface IUserService
    {
        [AuthRequired, AdminOnly] UserDTO? Retrieve(int userID);
        [AuthRequired, AdminOnly] List<UserDTO> RetrieveAll();
        [AuthRequired, SelfOnly(idKey: "userID")] bool Update(int userID, UserDTO? userDto);
        bool Login(CredentialsDTO? credentials);
        [AuthRequired] void Logout();
        bool Register(CredentialsDTO? credentials);
    }

    public class UserService : IUserService
    {
        public static IUserService Instance = AuthProxy<IUserService>.Create(new UserService());

        public static UserModel? User { get; private set; } = null;
        public static bool IsAuthenticated => User != null;
        public static bool IsAdmin => IsAuthenticated && User?.Rola != null && User.Rola.Equals("Admin");

        public UserDTO? Retrieve(int userID) => UserController.Retrieve(userID);
        public List<UserDTO> RetrieveAll() => UserController.RetrieveAll();
        public bool Update(int userID, UserDTO? userDto)
        {
            if (userDto == null) return false;
            bool status = UserController.UpdateUser(userID, userDto);
            if (status && User != null)
            {
                User.Name = userDto.Name;
                User.Email = userDto.Email;
                User.Phone = userDto.Phone;
            }
            return status;
        }
        public bool Login(CredentialsDTO? credentials)
        {
            if (credentials == null) return false;

            if (String.IsNullOrEmpty(credentials.Username)) return false;
            if (String.IsNullOrEmpty(credentials.Password)) return false;

            UserDTO? data = UserController.LoginUser(credentials);

            if (data == null)
            {
                User = null;
                return false;
            }

            UserService.User = new UserModel
            {
                ID = data.ID,
                Name = data.Name,
                Password = credentials.Password,
                Email = data.Email,
                Phone = data.Phone,
                Rola = data.Rola
            };

            return true;
        }
        public void Logout() => User = null;
        public bool Register(CredentialsDTO? credentials)
        {
            if (credentials == null) return false;

            if (String.IsNullOrEmpty(credentials.Username)) return false;
            if (String.IsNullOrEmpty(credentials.Password)) return false;
            if (String.IsNullOrEmpty(credentials.Email)) return false;
            if (String.IsNullOrEmpty(credentials.Phone)) return false;

            bool registered = UserController.RegistrateUser(credentials);
            return registered;
        }
    }
}