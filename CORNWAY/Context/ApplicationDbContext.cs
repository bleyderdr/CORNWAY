namespace CORNWAY.Model;
using Microsoft.EntityFrameworkCore;

public class ApplicatioDbContext : DbContext
{
    public DbSet<Personaje> Personajes { get; set; }
    public DbSet<Enemigo> Enemigos { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Arma> Armas { get; set; }
    public DbSet<Objeto> Objetos { get; set; }
    public DbSet<Semilla> Semillas { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
