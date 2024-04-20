using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IEnemigoRepository
    {
        Task<IEnumerable<Enemigo>> GetEnemigos();
        Task<Enemigo?> GetEnemigo(int id);
        Task<Enemigo> CreateEnemigo(Enemigo enemigo);
        Task<Enemigo> PutEnemigo(Enemigo enemigo);
        Task<Enemigo?> DeleteEnemigo(int id);
    }
    public class EnemigoRepository : IEnemigoRepository
    {
        private readonly ApplicationDbContext _db;
        public EnemigoRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Enemigo?> GetEnemigo(int id)
        {
            return await _db.Enemigo.FindAsync(id);
        }

        public async Task<IEnumerable<Enemigo>> GetEnemigos()
        {
            return await _db.Enemigo.ToListAsync();
        }

        public async Task<Enemigo> CreateEnemigo(Enemigo enemigo)
        {
            _db.Enemigo.Add(enemigo);
            await _db.SaveChangesAsync();
            return enemigo;
        }

        public async Task<Enemigo> PutEnemigo(Enemigo enemigo)
        {
            _db.Entry(enemigo).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return enemigo;
        }
        
        public async Task<Enemigo?> DeleteEnemigo(int id)
        {
            Enemigo? enemigo = await _db.Enemigo.FindAsync(id);
            if (enemigo == null) return enemigo;
            enemigo.IsActive = false;
            _db.Entry(enemigo).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return enemigo;
        }

    }
    
}
