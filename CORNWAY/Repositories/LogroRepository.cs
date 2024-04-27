using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface ILogroRepository
    {
        Task<IEnumerable<Logro>> GetLogros();
        Task<Logro?> GetLogro(int id);
        Task<Logro> CreateLogro(Logro logro);
        Task<Logro> PutLogro(Logro logro);
        Task<Logro?> DeleteLogro(int id);
    }
    public class LogroRepository : ILogroRepository
    {
        private readonly ApplicationDbContext _db;
        public LogroRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Logro?> GetLogro(int id)
        {
            return await _db.Logro.FindAsync(id);
        }

        public async Task<IEnumerable<Logro>> GetLogros()
        {
            return await _db.Logro.ToListAsync();
        }

        public async Task<Logro> CreateLogro(Logro logro)
        {
            _db.Logro.Add(logro);
            await _db.SaveChangesAsync();
            return logro;
        }

        public async Task<Logro> PutLogro(Logro logro)
        {
            _db.Entry(logro).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return logro;
        }
        
        public async Task<Logro?> DeleteLogro(int id)
        {
            Logro? logro = await _db.Logro.FindAsync(id);
            if (logro == null) return logro;
            logro.IsActive = false;
            _db.Entry(logro).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return logro;
        }

    }
}
