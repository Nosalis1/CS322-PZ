using static AutoService.Database.Database;
using AutoService.Models.Service;
using MySql.Data.MySqlClient;

namespace AutoService.Controllers
{
    internal static class ServiceController
    {
        const string QUERY_CREATE = @"
            INSERT INTO Servisi (Ime, Opis, Trajanje, Cena)
            VALUES (@Name, @Description, @Duration, @Price);
        ";
        const string QUERY_RETRIEVE = @"
            SELECT * FROM Servisi WHERE ID = @ID;
        ";
        const string QUERY_RETRIEVE_ALL = @"
            SELECT * FROM Servisi;
        ";
        const string QUERY_RETRIEVE_NAMES = @"
            SELECT DISTINCT ID, Ime FROM Servisi;     
        ";
        const string QUERY_UPDATE = @"
            UPDATE Servisi
            SET Ime = @Name, Opis = @Description, Trajanje = @Duration, Cena = @Price
            WHERE ID = @ID;
        ";
        const string QUERY_DELETE = @"
            DELETE FROM Servisi WHERE ID = @ID;     
        ";

        public static bool CreateService(ServiceDTO serviceDTO)
        {
            using (var command = new MySqlCommand(QUERY_CREATE, Connection))
            {
                command.Parameters.AddWithValue("@Name", serviceDTO.Name);
                command.Parameters.AddWithValue("@Description", serviceDTO.Description);
                command.Parameters.AddWithValue("@Duration", serviceDTO.Duration);
                command.Parameters.AddWithValue("@Price", serviceDTO.Price);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static ServiceModel? RetrieveService(int? serviceID)
        {
            if (serviceID == null) return null;
            using (var command = new MySqlCommand(QUERY_RETRIEVE, Connection))
            {
                command.Parameters.AddWithValue("@ID", serviceID);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ServiceModel
                        {
                            ID = reader.GetInt32("ID"),
                            Name = reader.GetString("Ime"),
                            Description = reader.GetString("Opis"),
                            Duration = reader.GetInt32("Trajanje"),
                            Price = (double)reader.GetDecimal("Cena")
                        };
                    }
                }
            }

            return null;
        }

        public static List<ServiceModel> RetrieveServices()
        {
            List<ServiceModel> allServices = new List<ServiceModel>();

            using (var command = new MySqlCommand(QUERY_RETRIEVE_ALL, Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allServices.Add(new ServiceModel
                        {
                            ID = reader.GetInt32("ID"),
                            Name = reader.GetString("Ime"),
                            Description = reader.GetString("Opis"),
                            Duration = reader.GetInt32("Trajanje"),
                            Price = (double)reader.GetDecimal("Cena")
                        });
                    }
                }
            }

            return allServices;
        }

        public static Dictionary<string, int> RetrieveServicesNames()
        {
            Dictionary<string, int> allServicesNames = new Dictionary<string, int>();

            using (var command = new MySqlCommand(QUERY_RETRIEVE_NAMES, Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID");
                        string name = reader.GetString("Ime");
                        allServicesNames[name] = id;
                    }
                }
            }

            return allServicesNames;
        }

        public static bool UpdateService(int serviceID, ServiceDTO serviceDTO)
        {
            using (var command = new MySqlCommand(QUERY_UPDATE, Connection))
            {
                command.Parameters.AddWithValue("@ID", serviceID);
                command.Parameters.AddWithValue("@Name", serviceDTO.Name);
                command.Parameters.AddWithValue("@Description", serviceDTO.Description);
                command.Parameters.AddWithValue("@Duration", serviceDTO.Duration);
                command.Parameters.AddWithValue("@Price", serviceDTO.Price);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteService(int serviceID)
        {
            using (var command = new MySqlCommand(QUERY_DELETE, Connection))
            {
                command.Parameters.AddWithValue("@ID", serviceID);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
