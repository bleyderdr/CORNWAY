using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IMascotaRepository
    {
        Task<IEnumerable<Mascota>> GetMascotas();
        Task<Mascota?> GetMascota(int id);
        Task<Mascota> CreateMascota(Mascota mascota);
        Task<Mascota> PutMascota(Mascota mascota);
        Task<Mascota?> DeleteMascota(int id);
    }
    public class MascotaRepository : IMascotaRepository
    {
        private readonly ApplicationDbContext _db;
        public MascotaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Mascota?> GetMascota(int id)
        {
            return await _db.Mascota.FindAsync(id);
        }

        public async Task<IEnumerable<Mascota>> GetMascotas()
        {
            return await _db.Mascota.ToListAsync();
        }

        public async Task<Mascota> CreateMascota(Mascota mascota)
        {
            _db.Mascota.Add(mascota);
            await _db.SaveChangesAsync();
            return mascota;
        }

        public async Task<Mascota> PutMascota(Mascota mascota)
        {
            _db.Entry(mascota).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return mascota;
        }
        
        public async Task<Mascota?> DeleteMascota(int id)
        {
            var mascota = await _db.Mascota.FindAsync(id);
            if (mascota == null)
            {
                return null;
            }
            _db.Mascota.Remove(mascota);
            await _db.SaveChangesAsync();
            return mascota;
        }

    }
    
}
