namespace BankAppAPI.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
    }
}
