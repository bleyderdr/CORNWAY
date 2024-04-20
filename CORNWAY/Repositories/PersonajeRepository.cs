using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;


namespace CORNWAY.Repositories
{
    public interface IPersonajeRepository
    {
        Task<IEnumerable<Personaje>> GetPersonajes();
        Task<Personaje?> GetPersonaje(int id);
        Task<Personaje> CreatePersonaje(Personaje personaje);
        Task<Personaje> PutPersonaje(Personaje personaje);
        Task<Personaje?> DeletePersonaje(int id);
    }
    public class PersonajeRepository : IPersonajeRepository
    {
        private readonly ApplicationDbContext _db;
        public PersonajeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<Personaje?> GetPersonaje(int id)
        {
            return await _db.Personaje.FindAsync(id);
        }

        public async Task<IEnumerable<Personaje>> GetPersonajes()
        {
            return await _db.Personaje.ToListAsync();
        }

        public async Task<Personaje> CreatePersonaje(Personaje personaje)
        {
            _db.Personaje.Add(personaje);
            await _db.SaveChangesAsync();
            return personaje;
        }

        public async Task<Personaje> PutPersonaje(Personaje personaje)
        {
            _db.Entry(personaje).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return personaje;
        }
        
        public async Task<Personaje?> DeletePersonaje(int id)
        {
            Personaje? personaje = await _db.Personaje.FindAsync(id);
            if (personaje == null) return personaje;
            personaje.IsActive = false;
            _db.Entry(personaje).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return personaje;
        }

    }
    
}
