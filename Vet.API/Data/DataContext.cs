using Microsoft.EntityFrameworkCore;
using Vet.Shared.Entities;

namespace Vet.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Mascota>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Producto>().HasIndex(s => s.Name);
            modelBuilder.Entity<Servicio>().HasIndex(f => f.Name);
        }
    }
}
  
    

