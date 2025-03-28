namespace Project.Models
{
    public class Notification
    {
        public required string PazinojumaId { get; set; }
        public required string Veids { get; set; }
        public required string Zina { get; set; }
        public DateTime NosutitsLaiks { get; set; }
        public required string ClientId { get; set; }
    }
}