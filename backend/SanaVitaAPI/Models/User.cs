using System.Collections.Generic;

namespace SanaVitaAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }  // e.g., Admin, Caregiver, Patient

        public ICollection<MedicationRequest> MedicationRequests { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
