using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public interface IMascotaService
    {
        Task<IEnumerable<Mascota>> GetMascotas();
        Task<Mascota?> GetMascota(int id);
        Task<Mascota> CreateMascota(
                      int Vida,
                      int Daño
                      );
        Task<Mascota> PutMascota(
                      int MascotaId,
                      int? Vida,
                      int? Daño
                       );
         
        Task<Mascota?> DeleteMascota(int id);
    }
    public class MascotaService(IMascotaRepository mascotaRepository) : IMascotaService
    {
        public async Task<Mascota?> GetMascota(int id)
        {
            return await mascotaRepository.GetMascota(id);
        }

        public async Task<IEnumerable<Mascota>> GetMascotas()
        {
            return await mascotaRepository.GetMascotas();
        }

        public async Task<Mascota> CreateMascota(
            int Vida,
            int Daño
            )
        {
            return await mascotaRepository.CreateMascota(new Mascota
            {
                Vida = Vida,
                Daño = Daño
            });
        }

        public async Task<Mascota> PutMascota(
            int MascotaId,
            int? Vida,
            int? Daño
            )
        {
           Mascota? newMasocta = await mascotaRepository.GetMascota(MascotaId);
            if (newMasocta == null)
            {
                throw new Exception("Mascota no encontrada");
            }
           else
            {
                newMasocta.Vida = Vida ?? newMasocta.Vida;
                newMasocta.Daño = Daño ?? newMasocta.Daño;

            }
            return await mascotaRepository.PutMascota(newMasocta);
        }

        public async Task<Mascota?> DeleteMascota(int id)
        {
            return await mascotaRepository.DeleteMascota(id);
        }


    }
}
