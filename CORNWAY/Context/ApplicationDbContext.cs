using System.Linq.Expressions;
using CORNWAY.Model;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Personaje> Personaje { get; set; }
        public DbSet<Enemigo> Enemigo { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Arma> Arma { get; set; }
        public DbSet<Semilla> Semilla { get; set; }
        public DbSet<Herramienta> Herramienta { get; set; }
        public DbSet<Fertilizante> Fertilizante { get; set; }
        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<Terreno> Terreno { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<TipoUser> TipoUser { get; set; }
        public DbSet<Logro> Logro { get; set; }
        public DbSet<Auth> Auth { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arma>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Enemigo>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Fertilizante>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Herramienta>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Mascota>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Personaje>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Semilla>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Sensor>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Terreno>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<User>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<TipoUser>().HasQueryFilter(e => e.IsActive);
            modelBuilder.Entity<Logro>().HasQueryFilter(e => e.IsActive);
        }
    }
}
