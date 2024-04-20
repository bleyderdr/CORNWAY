using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IFertilizanteRepository
    {
        Task<IEnumerable<Fertilizante>> GetFertilizantes();
        Task<Fertilizante?> GetFertilizante(int id);
        Task<Fertilizante> CreateFertilizante(Fertilizante fertilizante);
        Task<Fertilizante> PutFertilizante(Fertilizante fertilizante);
        Task<Fertilizante?> DeleteFertilizante(int id);
    }
    public class FertilizanteRepository : IFertilizanteRepository
    {
        private readonly ApplicationDbContext _db;
        public FertilizanteRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Fertilizante?> GetFertilizante(int id)
        {
            return await _db.Fertilizante.FindAsync(id);
        }

        public async Task<IEnumerable<Fertilizante>> GetFertilizantes()
        {
            return await _db.Fertilizante.ToListAsync();
        }

        public async Task<Fertilizante> CreateFertilizante(Fertilizante fertilizante)
        {
            _db.Fertilizante.Add(fertilizante);
            await _db.SaveChangesAsync();
            return fertilizante;
        }

        public async Task<Fertilizante> PutFertilizante(Fertilizante fertilizante)
        {
            _db.Entry(fertilizante).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return fertilizante;
        }
        
        public async Task<Fertilizante?> DeleteFertilizante(int id)
        {
            Fertilizante? fertilizante = await _db.Fertilizante.FindAsync(id);
            if (fertilizante == null) return fertilizante;
            fertilizante.IsActive = false;
            _db.Entry(fertilizante).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return fertilizante;
        }

    }
    
}
