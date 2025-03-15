using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoService.Models.User;
using AutoService.Controllers;

namespace AutoService.Services
{
    internal static class UserService
    {
        public static UserModel? User { get; private set; } = null;

        public static bool IsAuthenticated => User != null;
        public static bool IsAdmin => IsAuthenticated && User?.Rola != null && User.Rola.Equals("Admin");

        public static bool Login(CredentialsDTO? credentials)
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

            User = new UserModel
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

        public static void Logout() => User = null;

        public static bool Register(CredentialsDTO? credentials)
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