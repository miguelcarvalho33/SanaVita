using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaVitaAPI.Models
{
    public enum RequestStatus { Pending, Approved, Rejected }

    public class MedicationRequest
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int EMB_ID { get; set; }

        public DateTime RequestDate { get; set; }

        [Required]
        public RequestStatus Status { get; set; }

        public DateTime? ApprovedAt { get; set; }

        [StringLength(255)]
        public string? RejectionReason { get; set; }

        public User User { get; set; }
        [ForeignKey("EMB_ID")]
        public Embalagem Embalagem { get; set; }

        [Required]
        public bool IsForSelf { get; set; }

        [StringLength(100)]
        public string? RecipientName { get; set; }

    }
}

