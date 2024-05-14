using CORNWAY.Model;
using CORNWAY.Context;
using Microsoft.EntityFrameworkCore;

namespace CORNWAY.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User?> GetUser(int id);
        Task<User> CreateUser(User user);
        Task<User> PutUser(User user);
        Task<User?> DeleteUser(int id);
        Task<bool> Authenticate(Auth auth);
    }
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public async Task<User?> GetUser(int id)
        {
            return await _db.User.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _db.User.ToListAsync();
        }

        public async Task<User> CreateUser(User user)
        {
            _db.User.Add(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<User> PutUser(User user)
        {
            _db.Entry(user).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return user;
        }
        
        public async Task<User?> DeleteUser(int id)
        {
            User? user = await _db.User.FindAsync(id);
            if (user == null) return user;
            user.IsActive = false;
            _db.Entry(user).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<bool> Authenticate(Auth auth)
        {
            var user = await _db.User.SingleOrDefaultAsync(x => x.Email == auth.Email && x.Password == auth.Password);
            return user!= null;

        }

    }
    
}

