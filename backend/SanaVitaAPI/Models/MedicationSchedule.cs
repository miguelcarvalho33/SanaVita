using System.ComponentModel.DataAnnotations;

namespace SanaVitaAPI.Models
{

    public class MedicationSchedule
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int MedicationRequestId { get; set; }

        [Required]
        [StringLength(50)]
        public string Dosage { get; set; } = string.Empty;

        [Required]
        public string DosageUnits { get; set; }

        [Required]
        public string Frequency { get; set; }

        [Required]
        [StringLength(100)]
        public string FrequencyTimes { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Duration { get; set; } = string.Empty;

        public User User { get; set; }
        public MedicationRequest MedicationRequest { get; set; }
    }
}
