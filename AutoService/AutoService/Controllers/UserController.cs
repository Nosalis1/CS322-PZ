using static AutoService.Database.Database;
using AutoService.Models.User;
using MySql.Data.MySqlClient;

namespace AutoService.Controllers
{
    internal static class UserController
    {
        const string QUERY_GET = @"
            SELECT ID, Ime, Email, Telefon, Rola 
            FROM Korisnici 
            WHERE ID = @ID;
        ";

        const string QUERY_LOGIN = @"
            SELECT ID, Ime, Email, Telefon, Rola
            FROM Korisnici
            WHERE Ime = @Name AND Lozinka = @Password;
        ";

        const string QUERY_REGISTER = @"
            INSERT INTO Korisnici (Ime, Email, Telefon, Lozinka, Rola)
            VALUES (@Name, @Email, @Phone, @Password, 'User');
        ";


        public static UserDTO? GetUser(int userID)
        {
            using (var command = new MySqlCommand(QUERY_GET, Connection))
            {
                command.Parameters.AddWithValue("@ID", userID);


                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserDTO
                        {
                            ID = reader.GetInt32("ID"),
                            Name = reader.GetString("Ime"),
                            Email = reader.GetString("Email"),
                            Phone = reader.GetString("Telefon"),
                            Rola = reader.GetString("Rola")
                        };
                    }
                }
            }

            return null;
        }

        public static UserDTO? LoginUser(CredentialsDTO credentials)
        {
            using (var command = new MySqlCommand(QUERY_LOGIN, Connection))
            {
                command.Parameters.AddWithValue("@Name", credentials.Username);
                command.Parameters.AddWithValue("@Password", credentials.Password);

                using(var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserDTO
                        {
                            ID = reader.GetInt32("ID"),
                            Name = reader.GetString("Ime"),
                            Email = reader.GetString("Email"),
                            Phone = reader.GetString("Telefon"),
                            Rola = reader.GetString("Rola")
                        };
                    }
                }
            }

            return null;
        }

        public static bool RegistrateUser(CredentialsDTO credentials)
        {
            using (var command = new MySqlCommand(QUERY_REGISTER, Connection))
            {
                command.Parameters.AddWithValue("@Name", credentials.Username);
                command.Parameters.AddWithValue("@Email", credentials.Email);
                command.Parameters.AddWithValue("@Phone", credentials.Phone);
                command.Parameters.AddWithValue("@Password", credentials.Password);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
