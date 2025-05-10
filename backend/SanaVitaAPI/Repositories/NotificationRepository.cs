using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly AppDbContext _context;

        public NotificationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
            => await _context.Notifications.Include(n => n.User)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();

        public async Task<Notification?> GetByIdAsync(int id)
            => await _context.Notifications.Include(n => n.User)
                .FirstOrDefaultAsync(n => n.Id == id);

        public async Task AddAsync(Notification notification)
        {
            notification.CreatedAt = DateTime.UtcNow;
            notification.IsRead = false;
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
        }

        public async Task MarkAsReadAsync(int id)
        {
            var notif = await _context.Notifications.FindAsync(id);
            if (notif is null) return;
            notif.IsRead = true;
            await _context.SaveChangesAsync();
        }
    }
}
