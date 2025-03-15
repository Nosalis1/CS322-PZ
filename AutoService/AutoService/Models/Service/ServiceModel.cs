namespace AutoService.Models.Service
{
    public class ServiceModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
    }
}
