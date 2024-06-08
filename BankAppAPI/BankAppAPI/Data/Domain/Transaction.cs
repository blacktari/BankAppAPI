namespace BankAppAPI.Data.Domain
{
    public class Transaction
    {
        public string Id { get; set; }
        public string BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string DepositBank { get; set; }
        public string DepositAccount { get; set; }
    }
}
