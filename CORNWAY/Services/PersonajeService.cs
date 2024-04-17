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
              int DDinero,
              int Maiz
              );
        Task<Personaje> PutPersonaje(
              int PersonajeId,
              string? Nombre,
              int? Vida,
              int? Dinero,
              int? Maiz
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
                                                        int Maiz
                       )
        {
            return await personajeRepository.CreatePersonaje(new Personaje
            {
                Nombre = Nombre,
                Vida = Vida,
                Dinero = Dinero,
                Maiz = Maiz
            });
        }

        public async Task<Personaje> PutPersonaje(
                int PersonajeId,
                string? Nombre,
                int? Vida,
                int? Dinero,
                int? Maiz
                )
        {
           Personaje? newPersonaje = await personajeRepository.GetPersonaje(PersonajeId);
            if (newPersonaje == null)
            {
                throw new Exception("Personaje no encontrado");
            }
           else
            {
               newPersonaje.Nombre = Nombre ?? newPersonaje.Nombre;
                newPersonaje.Vida = Vida ?? newPersonaje.Vida;
                newPersonaje.Dinero = Dinero ?? newPersonaje.Dinero;
                newPersonaje.Maiz = Maiz ?? newPersonaje.Maiz;
               return await personajeRepository.PutPersonaje(newPersonaje);
           }
        }

        public async Task<Personaje?> DeletePersonaje(int id)
        {
            return await personajeRepository.DeletePersonaje(id);
        }
    }
    
}
