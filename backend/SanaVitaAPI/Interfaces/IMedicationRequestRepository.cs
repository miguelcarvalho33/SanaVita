using SanaVitaAPI.Models;

namespace SanaVitaAPI.Interfaces
{
    public interface IMedicationRequestRepository
    {
        Task<IEnumerable<MedicationRequest>> GetAllAsync();
        Task<MedicationRequest?> GetByIdAsync(int id);
        Task AddAsync(MedicationRequest request);
        Task ApproveAsync(int id);
        Task RejectAsync(int id, string reason);
    }
}
