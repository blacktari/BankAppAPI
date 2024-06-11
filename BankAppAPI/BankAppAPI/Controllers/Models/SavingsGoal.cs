// File: SavingsGoal.cs
using System;

namespace BankAppAPI.Models
{
    public class SavingsGoal
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Foreign key to link the savings goal to a user
        public string Name { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
