using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public interface IEnemigoService
    {
        Task<IEnumerable<Enemigo>> GetEnemigos();
        Task<Enemigo?> GetEnemigo(int id);
        Task<Enemigo> CreateEnemigo(
           int Vida,
           int Daño,
           int Recompenza
                       );
        Task<Enemigo> PutEnemigo(
           int EnemigoId,
           int? Vida,
           int? Daño,
           int? Recompenza
            );
         
        Task<Enemigo?> DeleteEnemigo(int id);
    }
    public class EnemigoService(IEnemigoRepository EnemigoRepository) : IEnemigoService
    {
        public async Task<Enemigo?> GetEnemigo(int id)
        {
            return await EnemigoRepository.GetEnemigo(id);
        }

        public async Task<IEnumerable<Enemigo>> GetEnemigos()
        {
            return await EnemigoRepository.GetEnemigos();
        }
        public async Task<Enemigo> CreateEnemigo(
            
            int Vida,
            int Daño,
            int Recompenza
                       )

        {
            return await EnemigoRepository.CreateEnemigo(new Enemigo
            {
                Vida = Vida,
                Daño = Daño,
                Recompenza = Recompenza

            });
        }
        public async Task<Enemigo> PutEnemigo(
            int EnemigoId,
            int? Vida,
            int? Daño,
            int? Recompenza
            )
        {
            Enemigo? newEnemigo = await EnemigoRepository.GetEnemigo(EnemigoId);
            if (newEnemigo == null)
            {
                throw new Exception("Enemigo no encontrado");
            }
            else
            {
                newEnemigo.Vida = Vida ?? newEnemigo.Vida;
                newEnemigo.Daño = Daño ?? newEnemigo.Daño;
                newEnemigo.Recompenza = Recompenza ?? newEnemigo.Recompenza;
                return await EnemigoRepository.PutEnemigo(newEnemigo);

            }
        }
        public async Task<Enemigo?> DeleteEnemigo(int id)
        {
            return await EnemigoRepository.DeleteEnemigo(id);
        }
    }

}
