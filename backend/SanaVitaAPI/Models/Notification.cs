using System.ComponentModel.DataAnnotations;

namespace SanaVitaAPI.Models
{
    public enum NotificationType { Alert, Reminder, Info }
    public enum NotificationPriority { Low, Medium, High }

    public class Notification
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string Message { get; set; } = string.Empty;

        public bool IsRead { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? TargetTime { get; set; }

        [Required]
        public NotificationType Type { get; set; }

        [Required]
        public NotificationPriority Priority { get; set; }

        public User User { get; set; }
    }
}
