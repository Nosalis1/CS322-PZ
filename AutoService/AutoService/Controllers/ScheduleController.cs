using static AutoService.Database.Database;
using AutoService.Models.Schedule;
using MySql.Data.MySqlClient;
using AutoService.Models.Service;

namespace AutoService.Controllers
{
    internal static class ScheduleController
    {
        const string QUERY_CREATE = @"
            INSERT INTO Termini (ServisID, DostupanDatum, DostupnoVreme, Status)
            VALUES (@ServiceID, @AvailableDate, @AvailableTime, @Status);
        ";
        const string QUERY_RETRIEVE = @"
            SELECT t.ID, t.DostupanDatum, t.DostupnoVreme, t.Status,
                   s.ID AS ServisID, s.Ime, s.Opis, s.Trajanje, s.Cena
            FROM Termini t
            JOIN Servisi s ON t.ServisID = s.ID
            WHERE t.ID = @ID;
        ";
        const string QUERY_RETRIEVE_ALL = @"
            SELECT t.ID, t.DostupanDatum, t.DostupnoVreme, t.Status,
                   s.ID AS ServisID, s.Ime, s.Opis, s.Trajanje, s.Cena
            FROM Termini t
            JOIN Servisi s ON t.ServisID = s.ID;
        ";
        const string QUERY_RETRIEVE_ALL_AVAILABLE = @"
            SELECT t.ID, t.DostupanDatum, t.DostupnoVreme, t.Status,
                   s.ID AS ServisID, s.Ime, s.Opis, s.Trajanje, s.Cena
            FROM Termini t
            JOIN Servisi s ON t.ServisID = s.ID
            LEFT JOIN Rezervacije r ON t.ID = r.TerminID
            WHERE r.ID IS NULL
            AND (t.DostupanDatum > CURDATE() 
                 OR (t.DostupanDatum = CURDATE() AND t.DostupnoVreme > CURTIME()))
        ";
        const string QUERY_UPDATE = @"
            UPDATE Termini
            SET ServisID = @ServiceID, DostupanDatum = @AvailableDate, DostupnoVreme = @AvailableTime, Status = @Status
            WHERE ID = @ID;
        ";
        const string QUERY_DELETE = @"
            DELETE FROM Termini WHERE ID = @ID;
        ";

        public static bool CreateSchedule(ScheduleDTO scheduleDTO)
        {
            using (var command = new MySqlCommand(QUERY_CREATE, Connection))
            {
                command.Parameters.AddWithValue("@ServiceID", scheduleDTO.ServiceID);
                command.Parameters.AddWithValue("@AvailableDate", scheduleDTO.AvailableDate);
                command.Parameters.AddWithValue("@AvailableTime", scheduleDTO.AvailableTime);
                command.Parameters.AddWithValue("@Status", scheduleDTO.Status);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static ScheduleModel? RetrieveSchedule(int? scheduleID)
        {
            if (scheduleID == null) return null;

            using (var command = new MySqlCommand(QUERY_RETRIEVE, Connection))
            {
                command.Parameters.AddWithValue("@ID", scheduleID);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ScheduleModel
                        {
                            ID = reader.GetInt32("ID"),
                            Service = new ServiceModel
                            {
                                ID = reader.GetInt32("ServisID"),
                                Name = reader.GetString("Ime"),
                                Description = reader.GetString("Opis"),
                                Duration = reader.GetInt32("Trajanje"),
                                Price = (double)reader.GetDecimal("Cena")
                            },
                            AvailableDate = reader.GetDateTime("DostupanDatum"),
                            AvailableTime = reader.GetTimeSpan("DostupnoVreme"),
                            Status = reader.GetString("Status")
                        };
                    }
                }
            }

            return null;
        }

        public static List<ScheduleModel> RetrieveSchedules()
        {
            List<ScheduleModel> allSchedules = new List<ScheduleModel>();

            using (var command = new MySqlCommand(QUERY_RETRIEVE_ALL, Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allSchedules.Add(new ScheduleModel
                        {
                            ID = reader.GetInt32("ID"),
                            Service = new ServiceModel
                            {
                                ID = reader.GetInt32("ServisID"),
                                Name = reader.GetString("Ime"),
                                Description = reader.GetString("Opis"),
                                Duration = reader.GetInt32("Trajanje"),
                                Price = (double)reader.GetDecimal("Cena")
                            },
                            AvailableDate = reader.GetDateTime("DostupanDatum"),
                            AvailableTime = reader.GetTimeSpan("DostupnoVreme"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return allSchedules;
        }

        public static List<ScheduleModel> RetieveAvailableSchedules()
        {
            List<ScheduleModel> allSchedules = new List<ScheduleModel>();

            using (var command = new MySqlCommand(QUERY_RETRIEVE_ALL_AVAILABLE, Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allSchedules.Add(new ScheduleModel
                        {
                            ID = reader.GetInt32("ID"),
                            Service = new ServiceModel
                            {
                                ID = reader.GetInt32("ServisID"),
                                Name = reader.GetString("Ime"),
                                Description = reader.GetString("Opis"),
                                Duration = reader.GetInt32("Trajanje"),
                                Price = (double)reader.GetDecimal("Cena")
                            },
                            AvailableDate = reader.GetDateTime("DostupanDatum"),
                            AvailableTime = reader.GetTimeSpan("DostupnoVreme"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return allSchedules;
        }

        public static bool UpdateSchedule(int scheduleID, ScheduleDTO scheduleDTO)
        {
            using (var command = new MySqlCommand(QUERY_UPDATE, Connection))
            {
                command.Parameters.AddWithValue("@ID", scheduleID);
                command.Parameters.AddWithValue("@ServiceID", scheduleDTO.ServiceID);
                command.Parameters.AddWithValue("@AvailableDate", scheduleDTO.AvailableDate);
                command.Parameters.AddWithValue("@AvailableTime", scheduleDTO.AvailableTime);
                command.Parameters.AddWithValue("@Status", scheduleDTO.Status);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteSchedule(int scheduleID)
        {
            using (var command = new MySqlCommand(QUERY_DELETE, Connection))
            {
                command.Parameters.AddWithValue("@ID", scheduleID);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
