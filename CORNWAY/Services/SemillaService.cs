using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public interface ISemillaService
    {
        Task<IEnumerable<Semilla>> GetSemillas();
        Task<Semilla?> GetSemilla(int id);
        Task<Semilla> CreateSemilla(
           int TiempoCrecimiento,
           int Precio,
           int PersonajeId
           );
        Task<Semilla> PutSemilla(
           int SemillaId,
           int? TiempoCrecimiento,
           int? Precio,
           int? PersonajeId
           );
         
        Task<Semilla?> DeleteSemilla(int id);
    }
    public class SemillaService(ISemillaRepository SemillaRepository) : ISemillaService
    {
        public async Task<Semilla?> GetSemilla(int id)
        {
            return await SemillaRepository.GetSemilla(id);
        }

        public async Task<IEnumerable<Semilla>> GetSemillas()
        {
            return await SemillaRepository.GetSemillas();
        }

        public async Task<Semilla> CreateSemilla(
            int TiempoCrecimiento,
            int Precio,
            int PersonajeId
                      )
        {
            return await SemillaRepository.CreateSemilla(new Semilla
            {
                TiempoCrecimiento = TiempoCrecimiento,
                Precio = Precio,
                PersonajeId = PersonajeId
            });
        }

        public async Task<Semilla> PutSemilla(
            int SemillaId,
            int? TiempoCrecimiento,
            int? Precio,
            int? PersonajeId
            )
        {
           Semilla? newSemilla = await SemillaRepository.GetSemilla(SemillaId);
            if (newSemilla == null)
            {
                throw new Exception("Semilla no encontrada");
            }
           else
            {
                newSemilla.TiempoCrecimiento = TiempoCrecimiento?? newSemilla.TiempoCrecimiento;
                newSemilla.Precio = Precio?? newSemilla.Precio;
                newSemilla.PersonajeId = PersonajeId?? newSemilla.PersonajeId;
                return await SemillaRepository.PutSemilla(newSemilla);
            }
        }

        public async Task<Semilla?> DeleteSemilla(int id)
        {
            return await SemillaRepository.DeleteSemilla(id);
        }
     }
    
}

