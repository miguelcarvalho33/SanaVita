using System.ComponentModel.DataAnnotations;

namespace SanaVitaAPI.Models
{
    public enum Role { Admin, Caregiver, Patient, Pharmacist }

    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength(80)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        public Role Role { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public bool IsDeleted { get; set; } = false;
        public ICollection<MedicationRequest> MedicationRequests { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
