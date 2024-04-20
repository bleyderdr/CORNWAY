using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface ISensorRepository
    {
        Task<IEnumerable<Sensor>> GetSensores();
        Task<Sensor?> GetSensor(int id);
        Task<Sensor> CreateSensor(Sensor sensor);
        Task<Sensor> PutSensor(Sensor sensor);
        Task<Sensor?> DeleteSensor(int id);
    }
    public class SensorRepository : ISensorRepository
    {
        private readonly ApplicationDbContext _db;
        public SensorRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Sensor?> GetSensor(int id)
        {
            return await _db.Sensor.FindAsync(id);
        }

        public async Task<IEnumerable<Sensor>> GetSensores()
        {
            return await _db.Sensor.ToListAsync();
        }

        public async Task<Sensor> CreateSensor(Sensor sensor)
        {
            _db.Sensor.Add(sensor);
            await _db.SaveChangesAsync();
            return sensor;
        }

        public async Task<Sensor> PutSensor(Sensor sensor)
        {
            _db.Entry(sensor).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return sensor;
        }
        
        public async Task<Sensor?> DeleteSensor(int id)
        {
            Sensor? sensor = await _db.Sensor.FindAsync(id);
            if (sensor == null) return sensor;
            sensor.IsActive = false;
            _db.Entry(sensor).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return sensor;
        }

    }
    
}
