using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public interface IHerramientaService
    {
        Task<IEnumerable<Herramienta>> GetHerramientas();
        Task<Herramienta?> GetHerramienta(int id);
        Task<Herramienta> CreateHerramienta(
           string Tipo,
           int PersonajeId
                                  );
        Task<Herramienta> PutHerramienta(
           int HerramientaId,
           string? Tipo,
           int? PersonajeId
                     );

        Task<Herramienta?> DeleteHerramienta(int id);
    }
    public class HerramientaService(IHerramientaRepository herramientaRepository) : IHerramientaService
    {
        public async Task<Herramienta?> GetHerramienta(int id)
        {
            return await herramientaRepository.GetHerramienta(id);
        }

        public async Task<IEnumerable<Herramienta>> GetHerramientas()
        {
            return await herramientaRepository.GetHerramientas();
        }
        public async Task<Herramienta> CreateHerramienta(
                       string Tipo,
                                  int PersonajeId
                       )

        {
            return await herramientaRepository.CreateHerramienta(new Herramienta
            {
                Tipo = Tipo,
                PersonajeId = PersonajeId

            });
        }
        public async Task<Herramienta> PutHerramienta(
            int HerramientaId,
            string? Tipo,
            int? PersonajeId
                       )
        {
            Herramienta? newHerramienta = await herramientaRepository.GetHerramienta(HerramientaId);
            if (newHerramienta == null)
            {
                throw new Exception("Herramienta no encontrada");
            }
            else
            {
                newHerramienta.Tipo = Tipo ?? newHerramienta.Tipo;
                newHerramienta.PersonajeId = PersonajeId ?? newHerramienta.PersonajeId;
                return await herramientaRepository.PutHerramienta(newHerramienta);
            }
        }
        public async Task<Herramienta?> DeleteHerramienta(int id)
        {
            return await herramientaRepository.DeleteHerramienta(id);
        }
    }
    
}
