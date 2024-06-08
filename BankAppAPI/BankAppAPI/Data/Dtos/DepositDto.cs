namespace BankAppAPI.Data.Dtos
{
    public class DepositDto
    {
        public string BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string DepositBank { get; set; }
        public string DepositAccount { get; set; }
    }
}
