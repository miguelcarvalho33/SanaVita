using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByUsernameAsync(string username)
            => await _context.Users.FirstOrDefaultAsync(u => u.Username == username);

        public async Task<User?> GetByIdAsync(int id)
            => await _context.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);

        public async Task<IEnumerable<User>> GetAllAsync()
            => await _context.Users.Where(u => !u.IsDeleted).ToListAsync();

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(string username)
            => await _context.Users.AnyAsync(u => u.Username == username);

        public async Task AnonymizeAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return;

            user.FullName = "anónimo";
            user.Email = null;
            user.PasswordHash = string.Empty;
            user.IsDeleted = true;

            await _context.SaveChangesAsync();
        }

    }
}
