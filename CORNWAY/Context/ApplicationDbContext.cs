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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
