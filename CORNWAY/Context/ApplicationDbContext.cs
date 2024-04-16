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



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
