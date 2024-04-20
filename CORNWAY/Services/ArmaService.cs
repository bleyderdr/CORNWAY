using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{ 
    public interface IArmaService
    {
        Task<IEnumerable<Arma>> GetArmas();
        Task<Arma?> GetArma(int id);
        Task<Arma> CreateArma(
            int Daño,
            string Tipo,
            int Precio,
            int PersonajeId
            );
        Task<Arma> PutArma(
            int ArmaId,
            int? Daño,
            string? Tipo,
            int? Precio,
            int? PersonajeId);
         
        Task<Arma?> DeleteArma(int id);
    }
    public class ArmaService(IArmaRepository ArmaRepository) : IArmaService
    { 
        public async Task<Arma?> GetArma(int id)
        {
            return await ArmaRepository.GetArma(id);
        }

        public async Task<IEnumerable<Arma>> GetArmas()
        {
            return await ArmaRepository.GetArmas();
        }
        public async Task<Arma> CreateArma(
            int Daño,
            string Tipo,
            int Precio,
            int PersonajeId
            )

        {
            return await ArmaRepository.CreateArma(new Arma
            { 
                Daño = Daño,
                Tipo = Tipo,
                Precio = Precio,
                PersonajeId = PersonajeId

            });
        }
        public async Task<Arma> PutArma(
              int ArmaId,
              int? Daño,
              string? Tipo,
              int? Precio,
              int? PersonajeId)

        {
            Arma? newArma = await ArmaRepository.GetArma(ArmaId);
            if (newArma == null)
            {
                throw new Exception("Arma no encontrada");
            }
            else
            {
                newArma.Daño = Daño ?? newArma.Daño;
                newArma.Tipo = Tipo ?? newArma.Tipo;
                newArma.Precio = Precio ?? newArma.Precio;
                newArma.PersonajeId = PersonajeId ?? newArma.PersonajeId;
                return await ArmaRepository.PutArma(newArma);
            }
        }
        
        public async Task<Arma?> DeleteArma(int id)
        {
            return await ArmaRepository.DeleteArma(id);
        }

    }    
 }

