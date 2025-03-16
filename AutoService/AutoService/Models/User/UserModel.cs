namespace AutoService.Models.User
{
    public class UserModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Rola { get; set; }
    }
}