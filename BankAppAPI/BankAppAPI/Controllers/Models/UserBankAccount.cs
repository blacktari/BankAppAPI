using System;

namespace BankAppAPI.Models
{
    public class UserBankAccount
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
    }
}
