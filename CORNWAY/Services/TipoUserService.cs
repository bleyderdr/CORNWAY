using CORNWAY.Model;
using CORNWAY.Repositories; 

namespace CORNWAY.Services
{
    public interface ITipoUserService
    {
        Task<IEnumerable<TipoUser>> GetTipoUsers();
        Task<TipoUser?> GetTipoUser(int id);
        Task<TipoUser> CreateTipoUser(
            string nombre
            );
        Task<TipoUser> PutTipoUser(
            int TipoUserId,
            string? nombre
                       );
        Task<TipoUser?> DeleteTipoUser(int id);
    }
    public class TipoUserService(ITipoUserRepository tipoUserRepository) : ITipoUserService
    {
        public async Task<TipoUser?> GetTipoUser(int id)
        {
            return await tipoUserRepository.GetTipoUser(id);
        }
        public async Task<IEnumerable<TipoUser>> GetTipoUsers()
        {
            return await tipoUserRepository.GetTipoUsers();
        }
        public async Task<TipoUser> CreateTipoUser(
            string nombre
            )
        {
            return await tipoUserRepository.CreateTipoUser(new TipoUser
            {
                Nombre = nombre
            });
        }
        public async Task<TipoUser> PutTipoUser(
            int TipoUserId,
            string? nombre
            )
        {
            TipoUser? tipoUser = await tipoUserRepository.GetTipoUser(TipoUserId);
            if (tipoUser == null) throw new Exception("TipoUser no encontrado");
            
            tipoUser.Nombre = nombre ?? tipoUser.Nombre;
            return await tipoUserRepository.PutTipoUser(tipoUser);
        }
        public async Task<TipoUser?> DeleteTipoUser(int id)
        {
            return await tipoUserRepository.DeleteTipoUser(id);
        }
    }

}
