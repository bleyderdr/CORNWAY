using CORNWAY.Context;
using CORNWAY.Model;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IArmaRepository
    {
        Task<IEnumerable<Arma>> GetArmas();
        Task<Arma?> GetArmaById(int id);
        Task<Arma> CreateArma(Arma arma);
        Task<Arma> PutArma(Arma arma);
        Task<Arma?> DeleteArma(int id);
    }

    public class ArmaRepository(ApplicationDbContext db) : IArmaRepository
    {
        public async Task<Arma?> GetArma(int id)
        {
            return await db.Arma.FindAsync(id);
        }

        public async Task<IEnumerable<Arma>> GetArmas()
        {
            return await db.Arma.ToListAsync();
        }

        public async Task<Arma> CreateArma(Arma arma)
        {
            db.Arma.Add(arma);
            await db.SaveChangesAsync();
            return arma;
        }

        public async Task<Arma> PutArma(Arma arma)
        {
            db.Entry(arma).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return arma;
        }

       

    }
}
