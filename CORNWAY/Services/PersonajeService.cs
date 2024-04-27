using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public interface IPersonajeService
    {
        Task<IEnumerable<Personaje>> GetPersonajes();
        Task<Personaje?> GetPersonaje(int id);
        Task<Personaje> CreatePersonaje(
              string Nombre,
              int Vida,
              int Dinero,
              int Maiz,
              int EnemigoId
              );
        Task<Personaje> PutPersonaje(
              int PersonajeId,
              string? Nombre,
              int? Vida,
              int? Dinero,
              int? Maiz,
              int? EnemigoId
              );
         
        Task<Personaje?> DeletePersonaje(int id);
    }
    public class PersonajeService(IPersonajeRepository personajeRepository) : IPersonajeService
    {
        public async Task<Personaje?> GetPersonaje(int id)
        {
            return await personajeRepository.GetPersonaje(id);
        }

        public async Task<IEnumerable<Personaje>> GetPersonajes()
        {
            return await personajeRepository.GetPersonajes();
        }

        public async Task<Personaje> CreatePersonaje(
            string Nombre,
            int Vida,
            int Dinero,
            int Maiz,
            int EnemigoId
                       )
        {
            return await personajeRepository.CreatePersonaje(new Personaje
            {
                Nombre = Nombre,
                Vida = Vida,
                Dinero = Dinero,
                Maiz = Maiz,
                EnemigoId = EnemigoId
            });
        }

        public async Task<Personaje> PutPersonaje(
                int PersonajeId,
                string? Nombre,
                int? Vida,
                int? Dinero,
                int? Maiz,
                int? EnemigoId
                )
        {
           Personaje? newPersonaje = await personajeRepository.GetPersonaje(PersonajeId);
            if (newPersonaje == null)throw new Exception("Personaje no encontrado");
           
               newPersonaje.Nombre = Nombre ?? newPersonaje.Nombre;
                newPersonaje.Vida = Vida ?? newPersonaje.Vida;
                newPersonaje.Dinero = Dinero ?? newPersonaje.Dinero;
                newPersonaje.Maiz = Maiz ?? newPersonaje.Maiz;
                newPersonaje.EnemigoId = EnemigoId ?? newPersonaje.EnemigoId;
               return await personajeRepository.PutPersonaje(newPersonaje);
           
        }

        public async Task<Personaje?> DeletePersonaje(int id)
        {
            return await personajeRepository.DeletePersonaje(id);
        }
    }
    
}
