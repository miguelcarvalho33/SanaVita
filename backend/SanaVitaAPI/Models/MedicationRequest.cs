using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaVitaAPI.Models
{
    public enum Status { Pending, Approved, Rejected }

    public class MedicationRequest
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int EMB_ID { get; set; }  // FK for EMBALAGEM

        public DateTime RequestDate { get; set; }

        public DateTime? ApprovedAt { get; set; }
        public Status Status { get; set; }

        public User User { get; set; }

        [ForeignKey("EMB_ID")]
        public Embalagem Embalagem { get; set; }
        public string RejectionReason { get; set; }
    }
}
