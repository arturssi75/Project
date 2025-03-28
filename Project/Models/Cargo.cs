using System;

namespace Project.Models
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public required string Description { get; set; }
        public decimal Weight { get; set; }
        public required string Dimensions { get; set; }
        public required string Sender { get; set; }
        public required string Receiver { get; set; }
        public required string Route { get; set; }
        public DateTime ExpectedDeliveryTime { get; set; }
        public required string Status { get; set; }
        public int VehicleId { get; set; }
        public required Vehicle Vehicle { get; set; }
    }
}