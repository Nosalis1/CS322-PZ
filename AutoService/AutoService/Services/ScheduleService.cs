using AutoService.Attributes;
using AutoService.Controllers;
using AutoService.Models.Schedule;

namespace AutoService.Services
{
    public interface IScheduleService
    {
        [AuthRequired, AdminOnly] bool Create(ScheduleDTO? scheduleDTO);
        [AuthRequired] ScheduleModel? Retrieve(int scheduleID);
        [AuthRequired] List<ScheduleModel> RetrieveAll();
        [AuthRequired] List<ScheduleModel> RetrieveAllAvailable();
        [AuthRequired, AdminOnly] bool Update(int scheduleID, ScheduleDTO? scheduleDTO);
        [AuthRequired, AdminOnly] bool Delete(int scheduleID);
    }

    public class ScheduleService : IScheduleService
    {
        private ScheduleService() { }

        public static IScheduleService Instance = AuthProxy<IScheduleService>.Create(new ScheduleService());

        public bool Create(ScheduleDTO? scheduleDTO)
        {
            if (scheduleDTO == null) return false;

            // TODO : Validation

            bool status = ScheduleController.CreateSchedule(scheduleDTO);
            return status;
        }
        public ScheduleModel? Retrieve(int scheduleID) => ScheduleController.RetrieveSchedule(scheduleID);
        public List<ScheduleModel> RetrieveAll() => ScheduleController.RetrieveSchedules();
        public List<ScheduleModel> RetrieveAllAvailable() => ScheduleController.RetieveAvailableSchedules();
        public bool Update(int scheduleID, ScheduleDTO? scheduleDTO)
        {
            if (scheduleDTO == null) return false;

            // TODO : Validation

            bool status = ScheduleController.UpdateSchedule(scheduleID, scheduleDTO);
            return status;
        }
        public bool Delete(int scheduleID) => ScheduleController.DeleteSchedule(scheduleID);
    }
}
