namespace AutoService.Models.Schedule
{
    public class ScheduleModel
    {
        public int ID { get; set; }
        public Service.ServiceModel? Service { get; set; }
        public string ServiceName => Service?.Name ?? "N/A";
        public double ServicePrice => Service?.Price ?? 0.0;
        public DateTime AvailableDate { get; set; }
        public TimeSpan AvailableTime { get; set; }
        public string? Status { get; set; }
    }
}