namespace Project.Models
{
    public class DeliveryReport
    {
        public required string AtskaitesId { get; set; }
        public DateTime PiegadesLaiks { get; set; }
        public required string SanemejaApstiprinajums { get; set; }
    }
}