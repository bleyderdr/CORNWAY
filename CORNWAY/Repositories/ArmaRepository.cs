using CORNWAY.Context;
using CORNWAY.Model;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IArmaRepository
    {
        Task<IEnumerable<Arma>> GetArmas();
        Task<Arma?> GetArma(int id);
        Task<Arma> CreateArma(Arma arma);
        Task<Arma> PutArma(Arma arma);
        Task<Arma?> DeleteArma(int id);
    }

    public class ArmaRepository : IArmaRepository 
    { 
        private readonly ApplicationDbContext _db;
        public ArmaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Arma?> GetArma(int id)
        {
            return await _db.Arma.FindAsync(id);
        }

        public async Task<IEnumerable<Arma>> GetArmas()
        {
            return await _db.Arma.ToListAsync();
        }

        public async Task<Arma> CreateArma(Arma arma)
        {
            _db.Arma.Add(arma);
            await _db.SaveChangesAsync();
            return arma;
        }

        public async Task<Arma> PutArma(Arma arma)
        {
            _db.Entry(arma).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return arma;
        }
        
        public async Task<Arma?> DeleteArma(int id)
        {
            var arma = await _db.Arma.FindAsync(id);
            if (arma == null)
            {
                return null;
            }
            _db.Arma.Remove(arma);
            await _db.SaveChangesAsync();
            return arma;
        }

    }
}
