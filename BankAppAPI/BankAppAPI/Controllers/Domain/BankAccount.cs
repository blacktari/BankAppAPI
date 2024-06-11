using System;

namespace BankAppApi.Controllers.Domain
{
    public class BankAccount
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinPhoneNumber { get; set; }
        public string AccountType { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StateOfOrigin { get; set; } // New property
        public string PasswordHash { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; internal set; }
    }
}
