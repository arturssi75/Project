namespace Project.Models
{
    public class Cargo
    {
        public required string KravasId { get; set; }
        public required string Sutitajs { get; set; }
        public required string Sanemejs { get; set; }
        public required string Apraksts { get; set; }
        public float Svars { get; set; }
        public required string Izmeri { get; set; }
        public required string Status { get; set; } // Piemēram: "Reģistrēts", "Ceļā", "Piegādāts", "Kavējas"
        public DateTime RegistretsLaiks { get; set; }
        public required int VehicleId { get; set; }
        public required Vehicle Vehicle { get; set; }
        public required List<Sensors> Sensors { get; set; }
        public required GPS Gps { get; set; }
        public required List<Notification> Notifications { get; set; }
        public required string Route { get; set; }
    }
}