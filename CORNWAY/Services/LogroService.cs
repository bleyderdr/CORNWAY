
using CORNWAY.Model;
using CORNWAY.Repositories;

namespace CORNWAY.Services
{
    public interface ILogroService
    {
        Task<IEnumerable<Logro>> GetLogros();
        Task<Logro?> GetLogro(int id);
        Task<Logro> CreateLogro(
            string nombre
            );
        Task<Logro> PutLogro(
            int LogroId,
            string? nombre
            );
        Task<Logro?> DeleteLogro(int id);
    }
    public class LogroService(ILogroRepository logroRepository) : ILogroService
    {
        public async Task<Logro?> GetLogro(int id)
        {
            return await logroRepository.GetLogro(id);
        }
        public async Task<IEnumerable<Logro>> GetLogros()
        {
            return await logroRepository.GetLogros();
        }
        public async Task<Logro> CreateLogro(
            string nombre
            )
        {
            return await logroRepository.CreateLogro(new Logro 
            { 
                Nombre = nombre
            });
        }
        public async Task<Logro> PutLogro(
            int LogroId,
            string? nombre
                       )
        {
            Logro? logro = await logroRepository.GetLogro(LogroId);
            if (logro == null) throw new Exception("Logro no encontrado");
            
            logro.Nombre = nombre ?? logro.Nombre;
            return await logroRepository.PutLogro(logro);
        }
        public async Task<Logro?> DeleteLogro(int id)
        {
            return await logroRepository.DeleteLogro(id);
        }
    }
    
}
