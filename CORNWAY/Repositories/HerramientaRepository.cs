using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IHerramientaRepository
    {
        Task<IEnumerable<Herramienta>> GetHerramientas();
        Task<Herramienta?> GetHerramienta(int id);
        Task<Herramienta> CreateHerramienta(Herramienta herramienta);
        Task<Herramienta> PutHerramienta(Herramienta herramienta);
        Task<Herramienta?> DeleteHerramienta(int id);
    }
    public class HerramientaRepository : IHerramientaRepository
    {
        private readonly ApplicationDbContext _db;
        public HerramientaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Herramienta?> GetHerramienta(int id)
        {
            return await _db.Herramienta.FindAsync(id);
        }

        public async Task<IEnumerable<Herramienta>> GetHerramientas()
        {
            return await _db.Herramienta.ToListAsync();
        }

        public async Task<Herramienta> CreateHerramienta(Herramienta herramienta)
        {
            _db.Herramienta.Add(herramienta);
            await _db.SaveChangesAsync();
            return herramienta;
        }

        public async Task<Herramienta> PutHerramienta(Herramienta herramienta)
        {
            _db.Entry(herramienta).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return herramienta;
        }
        
        public async Task<Herramienta?> DeleteHerramienta(int id)
        {
            Herramienta? herramienta = await _db.Herramienta.FindAsync(id);
            if (herramienta == null) return herramienta;
            herramienta.IsActive = false;
            _db.Entry(herramienta).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return herramienta;
        }
    }
}
