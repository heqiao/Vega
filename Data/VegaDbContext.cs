using Microsoft.EntityFrameworkCore;
using Vega.Entities;

namespace Vega.Data
{
    public class VegaDbContext:DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options):base(options) { }
        
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Make>().ToTable("Make");
            modelBuilder.Entity<Model>().ToTable("Model");
            modelBuilder.Entity<Feature>().ToTable("Feature");
        }
        
    }    
}

