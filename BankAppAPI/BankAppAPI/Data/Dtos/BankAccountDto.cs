namespace BankAppAPI.Data.Dtos
{
    public class BankAccountDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string PassportPhoto { get; set; }
        public string UtilityBill { get; set; }
        public string BVN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinPhoneNumber { get; set; }
        public string MothersName { get; set; }
        public string MothersPhoneNumber { get; set; }
        public string AccountType { get; set; } // Savings or Current
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PasswordHash { get; set; }
        public decimal Balance { get; set; }
    }
}
