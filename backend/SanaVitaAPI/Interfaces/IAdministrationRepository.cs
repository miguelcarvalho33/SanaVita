using SanaVitaAPI.Models;

namespace SanaVitaAPI.Interfaces
{
    public interface IAdministrationRepository
    {
        Task<IEnumerable<AdministrationEvent>> GetAllAsync();
        Task<AdministrationEvent?> GetByIdAsync(int id);
        Task RecordAsync(AdministrationEvent adminEvent);
    }
}
