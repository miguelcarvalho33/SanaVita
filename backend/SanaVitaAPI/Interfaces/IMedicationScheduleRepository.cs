using SanaVitaAPI.Models;

namespace SanaVitaAPI.Interfaces
{
    public interface IMedicationScheduleRepository
    {
        Task<IEnumerable<MedicationSchedule>> GetAllAsync();
        Task<MedicationSchedule?> GetByIdAsync(int id);
        Task AddAsync(MedicationSchedule schedule);
        Task UpdateAsync(MedicationSchedule schedule);
    }
}
