using SanaVitaAPI.Models;

public enum NotificationType { Alert, Reminder, Info }
public enum NotificationPriority { Low, Medium, High }

public class Notification
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? TargetTime { get; set; }
    public NotificationType Type { get; set; }
    public NotificationPriority Priority { get; set; }

    public User User { get; set; }
}
