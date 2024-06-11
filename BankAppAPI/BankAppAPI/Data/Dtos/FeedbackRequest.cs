using System.ComponentModel.DataAnnotations;

namespace BankAppAPI.Models
{
    public class FeedbackRequest
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        public string Comments { get; set; }
    }
}
