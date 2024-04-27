using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface ITipoUserRepository
    {
        Task<IEnumerable<TipoUser>> GetTipoUsers();
        Task<TipoUser?> GetTipoUser(int id);
        Task<TipoUser> CreateTipoUser(TipoUser tipoUser);
        Task<TipoUser> PutTipoUser(TipoUser tipoUser);
        Task<TipoUser?> DeleteTipoUser(int id);
    }
    public class TipoUserRepository : ITipoUserRepository
    {
        private readonly ApplicationDbContext _db;
        public TipoUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<TipoUser?> GetTipoUser(int id)
        {
            return await _db.TipoUser.FindAsync(id);
        }

        public async Task<IEnumerable<TipoUser>> GetTipoUsers()
        {
            return await _db.TipoUser.ToListAsync();
        }

        public async Task<TipoUser> CreateTipoUser(TipoUser tipoUser)
        {
            _db.TipoUser.Add(tipoUser);
            await _db.SaveChangesAsync();
            return tipoUser;
        }

        public async Task<TipoUser> PutTipoUser(TipoUser tipoUser)
        {
            _db.Entry(tipoUser).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return tipoUser;
        }
        
        public async Task<TipoUser?> DeleteTipoUser(int id)
        {
            TipoUser? tipoUser = await _db.TipoUser.FindAsync(id);
            if (tipoUser == null) return tipoUser;
            tipoUser.IsActive = false;
            _db.Entry(tipoUser).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return tipoUser;
        }

    }
    
}
