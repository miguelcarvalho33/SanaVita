using System.ComponentModel.DataAnnotations;

namespace SanaVitaAPI.Models
{
    public class AdministrationEvent
    {
        public int Id { get; set; }

        [Required]
        public int MedicationScheduleId { get; set; }

        public DateTime Timestamp { get; set; }

        [Required]
        [StringLength(100)]
        public string AdministeredBy { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Notes { get; set; }

        public MedicationSchedule MedicationSchedule { get; set; }
    }
}
