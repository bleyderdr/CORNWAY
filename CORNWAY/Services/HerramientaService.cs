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
           int Personaje
                                  );
        Task<Herramienta> PutHerramienta(
           int HerramientaId,
           string? Tipo,
           int? Personaje
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
                                  int Personaje
                       )

        {
            return await herramientaRepository.CreateHerramienta(new Herramienta
            {
                Tipo = Tipo,
                PersonajeId = Personaje

            });
        }
        public async Task<Herramienta> PutHerramienta(
            int HerramientaId,
            string? Tipo,
            int? Personaje
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
                newHerramienta.PersonajeId = Personaje ?? newHerramienta.PersonajeId;
                return await herramientaRepository.PutHerramienta(newHerramienta);
            }
        }
        public async Task<Herramienta?> DeleteHerramienta(int id)
        {
            return await herramientaRepository.DeleteHerramienta(id);
        }
    }
    
}
