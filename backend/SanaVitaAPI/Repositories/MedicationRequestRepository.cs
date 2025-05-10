using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public class MedicationRequestRepository : IMedicationRequestRepository
    {
        private readonly AppDbContext _context;

        public MedicationRequestRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MedicationRequest>> GetAllAsync()
            => await _context.MedicationRequests
                .Include(m => m.User)
                .Include(m => m.Embalagem)
                .ToListAsync();

        public async Task<MedicationRequest?> GetByIdAsync(int id)
            => await _context.MedicationRequests
                .Include(m => m.User)
                .Include(m => m.Embalagem)
                .FirstOrDefaultAsync(m => m.Id == id);

        public async Task AddAsync(MedicationRequest request)
        {
            request.RequestDate = DateTime.UtcNow;
            request.Status = Status.Pending;
            _context.MedicationRequests.Add(request);
            await _context.SaveChangesAsync();
        }

        public async Task ApproveAsync(int id)
        {
            var req = await _context.MedicationRequests.FindAsync(id);
            if (req is null) return;

            req.Status = Status.Approved;
            req.ApprovedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }

        public async Task RejectAsync(int id, string reason)
        {
            var req = await _context.MedicationRequests.FindAsync(id);
            if (req is null) return;

            req.Status = Status.Rejected;
            req.RejectionReason = reason;
            await _context.SaveChangesAsync();
        }
    }
}
