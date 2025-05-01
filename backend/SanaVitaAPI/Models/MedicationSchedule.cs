namespace SanaVitaAPI.Models
{
    public class MedicationSchedule
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int EMB_ID { get; set; }

        public string Dosage { get; set; }
        public string DosageUnits { get; set; }// e.g., "500mg"
        public string FrequencyTimes { get; set; } // e.g., "2x per day"
        public string Frequency { get; set; }
        public string Duration { get; set; }  // e.g., "7 days"

        public User User { get; set; }
    }
}
