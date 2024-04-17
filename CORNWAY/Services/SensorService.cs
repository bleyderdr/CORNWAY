using System.ComponentModel.DataAnnotations;
using CORNWAY.Context;
using CORNWAY.Model;
using CORNWAY.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Services
{
    public class ISensorService
    {
        Task<IEnumerable<Sensor>> GetSensors();
        Task<Sensor?> GetSensor(int id);
        Task<Sensor> CreateSensor(
            string Nombre,
            string Descripcion,
             );
        Task<Sensor> PutSensor(
            int SensorId,
            string Nombre,
            string Descripcion,
            );

        Task<Sensor?> DeleteSensor(int id);
    }
    public class SensorService(ISensorRepository SensorRepository) : ISensorService
    {
        public async Task<Sensor?> GetSensor(int id)
        {
            return await SensorRepository.GetSensor(id);
        }

        public async Task<IEnumerable<Sensor>> GetSensor()
        {
            return await SensorRepository.GetSensor();
        }
        public async Task<Sensor> CreateSensor(

            string Nombre,
            string Descripcion,
            )

        {
            return await SensorRepository.CreateSensor(new Sensor
            {
            string Nombre,
            string Descripcion,
            });
        }
        public async Task<Sensor> PutSensors(
              string? Nombre,
              string? Descripcion
            )

        {
            Sensor? newSensor = await SensorRepository.GetSensor(SensorId);
            if (newSensor == null)
            {
                throw new Exception("Sensor no encontrado");
            }
            else
            {
                newSensor.Nombre = Nombre ?? newSensor.Nombre;
                newSensor.Descripcion = Descripcion ?? newSensor.Descripcion;


                return await SensorRepository.PutSensor(newSensor);
            }
        }

        public async Task<Sensor?> DeleteSensor(int id)
        {
            return await SensorRepository.DeleteSensor(id);
        }

    }
}
