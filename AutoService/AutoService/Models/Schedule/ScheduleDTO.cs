namespace AutoService.Models.Schedule
{
    public class ScheduleDTO
    {
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public DateTime AvailableDate { get; set; }
        public TimeSpan AvailableTime { get; set; }
        public string? Status { get; set; }
    }
}
