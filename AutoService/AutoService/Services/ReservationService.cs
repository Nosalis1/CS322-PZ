using AutoService.Attributes;
using AutoService.Controllers;
using AutoService.Models.Reservation;

namespace AutoService.Services
{
    public interface IReservationService
    {

        [AuthRequired] bool Create(ReservationDTO? reservationDTO);
        [AuthRequired, AdminOnly] ReservationModel? Retrieve(int reservationID);
        [AuthRequired, AdminOnly] List<ReservationModel> RetrieveAll();
        [AuthRequired, SelfOnly(idKey: "userID", orAdmin: true)] List<ReservationModel> RetrieveAll(int userID);
        [AuthRequired, SelfOnly(idKey: "userID")] bool MakeReservation(int userID, int scheduleID);
        [AuthRequired, SelfOnly(idKey: "userID")] bool CancelReservation(int userID, int reservationID);
        [AuthRequired] bool Delete(int reservationID);
    }

    internal class ReservationService : IReservationService
    {
        private ReservationService() { }

        public static IReservationService Instance = AuthProxy<IReservationService>.Create(new ReservationService());

        public bool Create(ReservationDTO? reservationDTO)
        {
            if (reservationDTO == null) return false;

            // TODO : Validation

            bool status = ReservationController.CreateReservation(reservationDTO);
            return status;
        }

        public ReservationModel? Retrieve(int reservationID) => ReservationController.RetrieveReservation(reservationID);

        public List<ReservationModel> RetrieveAll() => ReservationController.RetrieveReservations();

        public List<ReservationModel> RetrieveAll(int userID) => ReservationController.RetrieveUserReservations(userID);

        public bool MakeReservation(int userID, int scheduleID) => ReservationController.CreateReservation(new ReservationDTO { UserID = userID, ScheduleID = scheduleID });

        public bool CancelReservation(int userID, int reservationID) => ReservationController.DeleteReservation(reservationID);

        public bool Delete(int reservationID) => ReservationController.DeleteReservation(reservationID);
    }
}