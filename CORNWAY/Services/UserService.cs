using CORNWAY.Model;
using CORNWAY.Repositories;

namespace CORNWAY.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User?> GetUser(int id);
        Task<User> CreateUser(
            string Username,
            string Email,
            string Password,
            int TipoUserId,
            int LogroId
                         );
        Task<User> PutUser(
           int UserId,
            string? Username,
            string? Email,
            string? Password,
            int? TipoUserId,
            int? LogroId
           );
         
        Task<User?> DeleteUser(int id);
    }
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public async Task<User?> GetUser(int id)
        {
            return await userRepository.GetUser(id);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await userRepository.GetUsers();
        }

        public async Task<User> CreateUser(
            string Username,
            string Email,
            string Password,
            int TipoUserId,
            int LogroId
            )
        {
            return await userRepository.CreateUser(new User
            {
                Username = Username,
                Email = Email,
                Password = Password,
                TipoUserId = TipoUserId,
                LogroId = LogroId
            });
        }

        public async Task<User> PutUser(
             int UserId,
             string? Username,
             string? Email,
             string? Password,
             int? TipoUserId,
             int? LogroId
                       )
        {
            User? user = await userRepository.GetUser(UserId);
            if (user == null) throw new Exception("User not found");
            
                user.Username = Username ?? user.Username;
                user.Email = Email ?? user.Email;
                user.Password = Password ?? user.Password;
                user.TipoUserId = TipoUserId ?? user.TipoUserId;
                user.LogroId = LogroId ?? user.LogroId;
                return await userRepository.PutUser(user);
        }

        public async Task<User?> DeleteUser(int id)
        {
            return await userRepository.DeleteUser(id);
        }
    }

}
