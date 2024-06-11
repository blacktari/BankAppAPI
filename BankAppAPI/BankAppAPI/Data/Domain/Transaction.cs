using System;

namespace BankAppAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Ensure this property exists
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
