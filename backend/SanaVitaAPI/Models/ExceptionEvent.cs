using System;

namespace SanaVitaAPI.Models
{
    public class ExceptionEvent
    {
        public int Id { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        public string Type { get; set; } = string.Empty; // e.g., MissedDose, ExpiredMedication
        public string Description { get; set; } = string.Empty;
        public DateTime OccurredAt { get; set; }
    }
}
