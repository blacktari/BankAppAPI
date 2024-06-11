using System.Threading.Tasks;
using BankAppAPI.Data;
using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly ApplicationDbContext _context;

        public FeedbackService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SubmitFeedback(FeedbackRequest feedbackRequest)
        {
            var feedback = new Feedback
            {
                UserId = feedbackRequest.UserId,
                Rating = feedbackRequest.Rating,
                Comments = feedbackRequest.Comments
            };

            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
        }
    }
}
