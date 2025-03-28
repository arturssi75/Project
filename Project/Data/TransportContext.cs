using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class TransportContext : DbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options) : base(options)
        {
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("TransportDb");
            }
        }
    }
}