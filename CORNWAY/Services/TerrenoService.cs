using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public class ITerrenoService
    {
        Task<IEnumerable<Terreno>> GetTerrenos();
        Task<Terreno?> GetTerreno(int id);
        Task<Terreno> CreateTerreno(
            int Humedad,
            int Temperatura,
            int SensorId,
            int FertiId,
            int SemillaId
             );
        Task<Terreno> PutTerreno(
            int TerrenoId,
            int Humedad,
            int Temperatura,
            int SensorId,
            int FertiId,
            int SemillaId
            );

        Task<Terreno?> DeleteTerreno(int id);
    }
    public class TerrenoService(ITerrenoRepository TerrenoRepository) : ITerrenoService
    {
        public async Task<Terreno?> GetTerreno(int id)
        {
            return await TerrenoRepository.GetTerreno(id);
        }

        public async Task<IEnumerable<Terreno>> GetTerreno()
        {
            return await TerrenoRepository.GetTerreno();
        }
        public async Task<Terreno> CreateTerreno(

            int Humedad,
            int Temperatura,
            int SensorId,
            int FertiId,
            int SemillaId,
            )

        {
            return await TerrenoRepository.CreateTerreno(new Terreno
            {
            int Humedad,
            int Temperatura,
            int SensorId,
            int FertiId,
            int SemillaId,

            });
        }
        public async Task<Terreno> PutTerrenos(
              int TerrenoId,
              int? Humedad,
              int? Temperatura,
              int? SensorId,
              int? FertiId,
              int? SemillaId,)

        {
            Terreno? newTerreno = await TerrenoRepository.GetTerreno(TerrenoId);
            if (newTerreno == null)
            {
                throw new Exception("Terreno no encontrado");
            }
            else
            {
                newTerreno.Humedad = Humedad ?? newTerreno.Humedad;
                newTerreno.Temperatura = Temperatura ?? newTerreno.Temperatura;
                newTerreno.SensorId = SensorId ?? newTerreno.SensorId;
                newTerreno.FertiId = FertiId ?? newTerreno.FertiId;
                newTerreno.SemillaId = SemillaId ?? newTerreno.SemillaId;

                return await TerrenoRepository.PutTerreno(newTerreno);
            }
        }

        public async Task<Terreno?> DeleteTerreno(int id)
        {
            return await TerrenoRepository.DeleteTerreno(id);
        }

    }
}
