namespace BankAppAPI.Data.Dtos
{
    public class WithdrawDto
    {
        public string BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
