using SanaVitaAPI.Models;

namespace SanaVitaAPI.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByUsernameAsync(string username);
        Task<User?> GetByIdAsync(int id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task<bool> ExistsAsync(string username);
    }
}
