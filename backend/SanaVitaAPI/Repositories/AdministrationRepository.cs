using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public class AdministrationRepository : IAdministrationRepository
    {
        private readonly AppDbContext _context;

        public AdministrationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AdministrationEvent>> GetAllAsync()
            => await _context.AdministrationEvents
                .Include(a => a.MedicationSchedule)
                .ThenInclude(s => s.User)
                .ToListAsync();

        public async Task<AdministrationEvent?> GetByIdAsync(int id)
            => await _context.AdministrationEvents
                .Include(a => a.MedicationSchedule)
                .ThenInclude(s => s.User)
                .FirstOrDefaultAsync(a => a.Id == id);

        public async Task RecordAsync(AdministrationEvent adminEvent)
        {
            adminEvent.Timestamp = DateTime.UtcNow;
            _context.AdministrationEvents.Add(adminEvent);
            await _context.SaveChangesAsync();
        }
    }
}
