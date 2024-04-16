using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface ITerrenoRepository
    {
        Task<IEnumerable<Terreno>> GetTerrenos();
        Task<Terreno?> GetTerreno(int id);
        Task<Terreno> CreateTerreno(Terreno terreno);
        Task<Terreno> PutTerreno(Terreno terreno);
        Task<Terreno?> DeleteTerreno(int id);
    }
    public class TerrenoRepository : ITerrenoRepository
    {
        private readonly ApplicationDbContext _db;
        public TerrenoRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Terreno?> GetTerreno(int id)
        {
            return await _db.Terreno.FindAsync(id);
        }

        public async Task<IEnumerable<Terreno>> GetTerrenos()
        {
            return await _db.Terreno.ToListAsync();
        }

        public async Task<Terreno> CreateTerreno(Terreno terreno)
        {
            _db.Terreno.Add(terreno);
            await _db.SaveChangesAsync();
            return terreno;
        }

        public async Task<Terreno> PutTerreno(Terreno terreno)
        {
            _db.Entry(terreno).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return terreno;
        }
        
        public async Task<Terreno?> DeleteTerreno(int id)
        {
            var terreno = await _db.Terreno.FindAsync(id);
            if (terreno == null)
            {
                return null;
            }
            _db.Terreno.Remove(terreno);
            await _db.SaveChangesAsync();
            return terreno;
        }

    }
    
}
