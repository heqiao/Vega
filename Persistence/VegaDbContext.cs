using Microsoft.EntityFrameworkCore;
using Vega.Entities;

namespace Vega.Persistence
{
    public class VegaDbContext:DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options):base(options) { }
        
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Make>().ToTable("Makes");
            modelBuilder.Entity<Model>().ToTable("Models");
            modelBuilder.Entity<Feature>().ToTable("Features");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<VehicleFeature>().ToTable("VehicleFeatures");
            
            
            modelBuilder.Entity<Make>().Property(m => m.Name).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Model>().Property(m => m.Name).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Feature>().Property(m => m.Name).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Vehicle>().Property(m => m.ContactName).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Vehicle>().Property(m => m.ContactPhone).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Vehicle>().Property(m => m.ContactEmail).HasMaxLength(255);

            // Set up M-M relationship
            modelBuilder.Entity<ModelFeature>()
            .HasKey(t => new { t.ModelId, t.FeatureId});

            modelBuilder.Entity<VehicleFeature>()
            .HasKey(vf => new { vf.VehicleId, vf.FeatureId });

            modelBuilder.Entity<ModelFeature>()
            .HasOne(mf => mf.Model)
            .WithMany(m => m.ModelFeatures)
            .HasForeignKey(mf => mf.ModelId);

            modelBuilder.Entity<ModelFeature>()
            .HasOne(mf => mf.Feature)
            .WithMany(f => f.ModelFeatures)
            .HasForeignKey(mf => mf.FeatureId);
            
        }        
    }    
}

