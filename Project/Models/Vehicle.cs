namespace Project.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public required string Type { get; set; }
        public required string LicensePlate { get; set; }
        public required string DriverName { get; set; }
    }
}