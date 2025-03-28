namespace Project.Models
{
    public class GPS
    {
       public int GPSId { get; set; }
        public required string AtrasanasVieta { get; set; }
        public required string Koordinatas { get; set; }
        public DateTime IegutsLaiks { get; set; }
        public required string CargoId { get; set; }
    }
}