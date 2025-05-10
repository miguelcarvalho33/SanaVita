using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Models;

namespace SanaVitaAPI.Repositories
{
    public class MedicationScheduleRepository : IMedicationScheduleRepository
    {
        private readonly AppDbContext _context;

        public MedicationScheduleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MedicationSchedule>> GetAllAsync()
            => await _context.MedicationSchedules
                .Include(m => m.User)
                .Include(m => m.MedicationRequest)
                .ToListAsync();

        public async Task<MedicationSchedule?> GetByIdAsync(int id)
            => await _context.MedicationSchedules
                .Include(m => m.User)
                .Include(m => m.MedicationRequest)
                .FirstOrDefaultAsync(m => m.Id == id);

        public async Task AddAsync(MedicationSchedule schedule)
        {
            _context.MedicationSchedules.Add(schedule);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(MedicationSchedule schedule)
        {
            _context.MedicationSchedules.Update(schedule);
            await _context.SaveChangesAsync();
        }
    }
}
