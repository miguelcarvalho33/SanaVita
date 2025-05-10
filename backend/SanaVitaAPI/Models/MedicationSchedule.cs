using SanaVitaAPI.Models;

public class MedicationSchedule
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public int MedicationRequestId { get; set; }

    public string Dosage { get; set; } // "1", "0.5", etc.
    public string DosageUnits { get; set; }
    public string Frequency { get; set; }
    public string Duration { get; set; }  // Ex: "7 days"

    public User User { get; set; }
    public MedicationRequest MedicationRequest { get; set; }
}
