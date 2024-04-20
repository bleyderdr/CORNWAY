using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface ISemillaRepository
    {
        Task<IEnumerable<Semilla>> GetSemillas();
        Task<Semilla?> GetSemilla(int id);
        Task<Semilla> CreateSemilla(Semilla semilla);
        Task<Semilla> PutSemilla(Semilla semilla);
        Task<Semilla?> DeleteSemilla(int id);
    }
    public class SemillaRepository : ISemillaRepository
    {
        private readonly ApplicationDbContext _db;
        public SemillaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Semilla?> GetSemilla(int id)
        {
            return await _db.Semilla.FindAsync(id);
        }

        public async Task<IEnumerable<Semilla>> GetSemillas()
        {
            return await _db.Semilla.ToListAsync();
        }

        public async Task<Semilla> CreateSemilla(Semilla semilla)
        {
            _db.Semilla.Add(semilla);
            await _db.SaveChangesAsync();
            return semilla;
        }

        public async Task<Semilla> PutSemilla(Semilla semilla)
        {
            _db.Entry(semilla).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return semilla;
        }
        
        public async Task<Semilla?> DeleteSemilla(int id)
        {
            Semilla? semilla = await _db.Semilla.FindAsync(id);
            if (semilla == null) return semilla;
            semilla.IsActive = false;
            _db.Entry(semilla).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return semilla;
        }
    }
    
}
