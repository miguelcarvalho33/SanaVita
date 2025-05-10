using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SanaVitaAPI.Models
{
    public enum Role { Patient, Caregiver, Pharmacist, Admin }

    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserName { get; set; } = string.Empty;
        public string Username { get; internal set; }
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        [Required]
        public Role Role { get; set; }

        public DateOnly DOB { get; set; }

        public ICollection<MedicationRequest> MedicationRequests { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
