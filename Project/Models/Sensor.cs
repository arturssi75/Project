using System;

namespace Project.Models
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public required string Type { get; set; }
        public required string Value { get; set; }
        public DateTime Timestamp { get; set; }
        public int CargoId { get; set; }
        public required Cargo Cargo { get; set; }
        public int LocationId { get; internal set; }
    }
}