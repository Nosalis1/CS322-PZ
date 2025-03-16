using AutoService.Models.Schedule;
using AutoService.Models.User;

namespace AutoService.Models.Reservation
{
    public class ReservationModel
    {
        public int ID { get; set; }
        public UserModel User { get; set; }
        public string UserName => User?.Name ?? "N/A";
        public string Email => User?.Email ?? "N/A";
        public string Phone => User?.Phone ?? "N/A";
        public ScheduleModel Schedule { get; set; }
        public string ServiceName => Schedule?.ServiceName ?? "N/A";
        public double ServicePrice => Schedule?.ServicePrice ?? 0.0;
        public DateTime AvailableDate => Schedule?.AvailableDate ?? DateTime.MinValue;
        public TimeSpan AvailableTime => Schedule?.AvailableTime ?? TimeSpan.Zero;
        public string Status => Schedule?.Status ?? "N/A";
    }
}
