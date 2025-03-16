using static AutoService.Database.Database;
using AutoService.Models.Reservation;
using MySql.Data.MySqlClient;

namespace AutoService.Controllers
{
    internal static class ReservationController
    {
        const string QUERY_CREATE = @"
            INSERT INTO Rezervacije (KorisnikID, TerminID)
            VALUES (@UserID, @ScheduleID);
        ";
        const string QUERY_RETRIEVE = @"
            SELECT r.ID,
                    s.ID as ServiceID, s.Ime as ServiceName, s.Opis, s.Trajanje, s.Cena,
                    t.ID as ScheduleID, t.DostupanDatum, t.DostupnoVreme, t.Status,
                    u.ID as UserID, u.Ime as UserName, u.Email, u.Telefon
            FROM Rezervacije r
            JOIN Termini t ON r.TerminID = t.ID
            JOIN Servisi s ON t.ServisID = s.ID
            JOIN Korisnici u ON r.KorisnikID = u.ID
            WHERE r.ID = @ID;
        ";
        const string QUERY_RETRIEVE_ALL = @"
            SELECT r.ID,
                    s.ID as ServiceID, s.Ime as ServiceName, s.Opis, s.Trajanje, s.Cena,
                    t.ID as ScheduleID, t.DostupanDatum, t.DostupnoVreme, t.Status,
                    u.ID as UserID, u.Ime as UserName, u.Email, u.Telefon
            FROM Rezervacije r
            JOIN Termini t ON r.TerminID = t.ID
            JOIN Servisi s ON t.ServisID = s.ID
            JOIN Korisnici u ON r.KorisnikID = u.ID;
        ";
        const string QUERY_RETRIEVE_USER_ALL = @"
            SELECT r.ID,
                    s.ID as ServiceID, s.Ime as ServiceName, s.Opis, s.Trajanje, s.Cena,
                    t.ID as ScheduleID, t.DostupanDatum, t.DostupnoVreme, t.Status,
                    u.ID as UserID, u.Ime as UserName, u.Email, u.Telefon
            FROM Rezervacije r
            JOIN Termini t ON r.TerminID = t.ID
            JOIN Servisi s ON t.ServisID = s.ID
            JOIN Korisnici u ON r.KorisnikID = u.ID
            WHERE u.ID = @ID;
        ";
        const string QUERY_DELETE = @"
            DELETE FROM Rezervacije WHERE ID = @ID;
        ";

        public static bool CreateReservation(ReservationDTO reservationDTO)
        {
            using (var command = new MySqlCommand(QUERY_CREATE, Connection))
            {
                command.Parameters.AddWithValue("@UserID", reservationDTO.UserID);
                command.Parameters.AddWithValue("@ScheduleID", reservationDTO.ScheduleID);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static ReservationModel? RetrieveReservation(int? reservationID)
        {
            if (reservationID == null) return null;

            using (var command = new MySqlCommand(QUERY_RETRIEVE, Connection))
            {
                command.Parameters.AddWithValue("@ID", reservationID);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ReservationModel
                        {
                            ID = reader.GetInt32("ID"),
                            Schedule = new Models.Schedule.ScheduleModel
                            {
                                ID = reader.GetInt32("ScheduleID"),
                                Service = new Models.Service.ServiceModel
                                {
                                    ID = reader.GetInt32("ServiceID"),
                                    Name = reader.GetString("ServiceName"),
                                    Description = reader.GetString("Opis"),
                                    Duration = reader.GetInt32("Trajanje"),
                                    Price = (double)reader.GetDecimal("Cena")
                                },
                                AvailableDate = reader.GetDateTime("DostupanDatum"),
                                AvailableTime = reader.GetTimeSpan("DostupnoVreme"),
                                Status = reader.GetString("Status")
                            },
                            User = new Models.User.UserModel
                            {
                                ID = reader.GetInt32("UserID"),
                                Name = reader.GetString("UserName"),
                                Email = reader.GetString("Email"),
                                Phone = reader.GetString("Telefon"),
                                Rola = "User"
                            }
                        };
                    }
                }
            }

            return null;
        }

        public static List<ReservationModel> RetrieveReservations()
        {
            List<ReservationModel> allReservations = new List<ReservationModel>();

            using (var command = new MySqlCommand(QUERY_RETRIEVE_ALL, Connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allReservations.Add(new ReservationModel
                        {
                            ID = reader.GetInt32("ID"),
                            Schedule = new Models.Schedule.ScheduleModel
                            {
                                ID = reader.GetInt32("ScheduleID"),
                                Service = new Models.Service.ServiceModel
                                {
                                    ID = reader.GetInt32("ServiceID"),
                                    Name = reader.GetString("ServiceName"),
                                    Description = reader.GetString("Opis"),
                                    Duration = reader.GetInt32("Trajanje"),
                                    Price = (double)reader.GetDecimal("Cena")
                                },
                                AvailableDate = reader.GetDateTime("DostupanDatum"),
                                AvailableTime = reader.GetTimeSpan("DostupnoVreme"),
                                Status = reader.GetString("Status")
                            },
                            User = new Models.User.UserModel
                            {
                                ID = reader.GetInt32("UserID"),
                                Name = reader.GetString("UserName"),
                                Email = reader.GetString("Email"),
                                Phone = reader.GetString("Telefon"),
                                Rola = "User"
                            }
                        });
                    }
                }
            }

            return allReservations;
        }

        public static List<ReservationModel> RetrieveUserReservations(int userID)
        {
            List<ReservationModel> allReservations = new List<ReservationModel>();

            using (var command = new MySqlCommand(QUERY_RETRIEVE_USER_ALL, Connection))
            {
                command.Parameters.AddWithValue("@ID", userID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allReservations.Add(new ReservationModel
                        {
                            ID = reader.GetInt32("ID"),
                            Schedule = new Models.Schedule.ScheduleModel
                            {
                                ID = reader.GetInt32("ScheduleID"),
                                Service = new Models.Service.ServiceModel
                                {
                                    ID = reader.GetInt32("ServiceID"),
                                    Name = reader.GetString("ServiceName"),
                                    Description = reader.GetString("Opis"),
                                    Duration = reader.GetInt32("Trajanje"),
                                    Price = (double)reader.GetDecimal("Cena")
                                },
                                AvailableDate = reader.GetDateTime("DostupanDatum"),
                                AvailableTime = reader.GetTimeSpan("DostupnoVreme"),
                                Status = reader.GetString("Status")
                            },
                            User = new Models.User.UserModel
                            {
                                ID = reader.GetInt32("UserID"),
                                Name = reader.GetString("UserName"),
                                Email = reader.GetString("Email"),
                                Phone = reader.GetString("Telefon"),
                                Rola = "User"
                            }
                        });
                    }
                }
            }

            return allReservations;
        }

        public static bool DeleteReservation(int reservationID)
        {
            using (var command = new MySqlCommand(QUERY_DELETE, Connection))
            {
                command.Parameters.AddWithValue("@ID", reservationID);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}