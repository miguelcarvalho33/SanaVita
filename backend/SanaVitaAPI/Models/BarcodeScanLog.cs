using System;

namespace SanaVitaAPI.Models
{
    public class BarcodeScanLog
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Barcode { get; set; } = string.Empty;
        public DateTime ScannedAt { get; set; }
    }
}
