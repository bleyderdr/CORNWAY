using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public interface IFertilizanteService
    {
        Task<IEnumerable<Fertilizante>> GetFertilizantes();
        Task<Fertilizante?> GetFertilizante(int id);
        Task<Fertilizante> CreateFertilizante(
            string Nombre
             );
        Task<Fertilizante> PutFertilizante(
            int FertiId,
            string? Nombre
            );

        Task<Fertilizante?> DeleteFertilizante(int id);
    }
    public class FertilizanteService(IFertilizanteRepository FertilizanteRepository) : IFertilizanteService
    {
        public async Task<Fertilizante?> GetFertilizante(int id)
        {
            return await FertilizanteRepository.GetFertilizante(id);
        }

        public async Task<IEnumerable<Fertilizante>> GetFertilizantes()
        {
            return await FertilizanteRepository.GetFertilizantes();
        }
        public async Task<Fertilizante> CreateFertilizante(
                                  string Nombre
                                  )

        {
            return await FertilizanteRepository.CreateFertilizante(new Fertilizante
            {
                Nombre = Nombre

            });
        }
        public async Task<Fertilizante> PutFertilizante(
            int FertiId,
            string? Nombre           
            )
        {
           Fertilizante? newFertiliznate = await FertilizanteRepository.GetFertilizante(FertiId);
            if (newFertiliznate == null)
            {
                throw new Exception("Fertilizante no encontrado");
            }
           else
            {
                newFertiliznate.Nombre = Nombre ?? newFertiliznate.Nombre;
                return await FertilizanteRepository.PutFertilizante(newFertiliznate);
            }
        }
        
        public async Task<Fertilizante?> DeleteFertilizante(int id)
        {
            return await FertilizanteRepository.DeleteFertilizante(id);
        }
    }
    
}
