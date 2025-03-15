using static AutoService.Database.Database;
using AutoService.Models.Schedule;
using MySql.Data.MySqlClient;

namespace AutoService.Controllers
{
    internal static class ScheduleController
    {
        const string QUERY_CREATE = @"
            INSERT INTO Termini (ServisID, DostupanDatum, DostupnoVreme, Status)
            VALUES (@ServiceID, @AvailableDate, @AvailableTime, @Status);
        ";
        const string QUERY_RETRIEVE = @"
            SELECT * FROM Termini WHERE ID = @ID;
        ";
        const string QUERY_RETRIEVE_ALL = @"
            SELECT * FROM Termini;
        ";
        const string QUERY_UPDATE = @"
            UPDATE Termini
            SET ServisID = @ServiceID, DostupanDatum = @AvailableDate, DostupnoVreme = @AvailableTime, Status = @Status
            WHERE ID = @ID;
        ";
        const string QUERY_DELETE = @"
            DELETE FROM Termini WHERE ID = @ID;
        ";
    }
}
