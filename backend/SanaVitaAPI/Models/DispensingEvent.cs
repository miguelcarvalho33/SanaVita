using System;

namespace SanaVitaAPI.Models
{
    public class DispensingEvent
    {
        public int Id { get; set; }

        public int MedicationRequestId { get; set; }
        public MedicationRequest MedicationRequest { get; set; }

        public DateTime DispensedAt { get; set; }
        public string DispensedBy { get; set; } = string.Empty;
        public int QuantityDispensed { get; set; }
    }
}
