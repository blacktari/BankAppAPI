namespace BankAppAPI.Data.Dtos
{
    public class CreateBankAccountDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; } // Change to string for custom format parsing
        public string NextOfKinName { get; set; }
        public string NextOfKinPhoneNumber { get; set; }
        public string AccountType { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StateOfOrigin { get; set; } // New property
        public string Password { get; set; }
    }
}
