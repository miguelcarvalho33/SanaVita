using System;

namespace SanaVitaAPI.Models
{
    public class AdministrationEvent
    {
        public int Id { get; set; }

        public int MedicationScheduleId { get; set; }
        public MedicationSchedule MedicationSchedule { get; set; }

        public DateTime Timestamp { get; set; }
        public string AdministeredBy { get; set; } = string.Empty;
        public string? Notes { get; set; }
    }
}
