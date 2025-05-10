using SanaVitaAPI.Models;

namespace SanaVitaAPI.Interfaces
{
    public interface INotificationRepository
    {
        Task<IEnumerable<Notification>> GetAllAsync();
        Task<Notification?> GetByIdAsync(int id);
        Task AddAsync(Notification notification);
        Task MarkAsReadAsync(int id);
    }
}
