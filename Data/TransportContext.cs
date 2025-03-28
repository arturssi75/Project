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
        public DbSet<Sensors> Sensors { get; set; }
        public DbSet<GPS> GPSs { get; set; }
        public DbSet<Dispatcher> Dispatchers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Models.Route> Routes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<DeliveryReport> PiegadesAtskaites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("TransportDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>()
                .HasOne(c => c.Vehicle)
                .WithMany()
                .HasForeignKey(c => c.VehicleId);

            modelBuilder.Entity<Cargo>()
                .HasMany(c => c.Sensors)
                .WithOne(s => s.Cargo)
                .HasForeignKey(s => s.CargoId);

             modelBuilder.Entity<Cargo>()
                .HasOne(c => c.Gps)
                .WithOne()
                .HasForeignKey<GPS>(g => g.CargoId);
        }
    }
}