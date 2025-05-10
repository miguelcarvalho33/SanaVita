using System;

namespace SanaVitaAPI.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int EMB_ID { get; set; }
        public Embalagem Embalagem { get; set; }

        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
