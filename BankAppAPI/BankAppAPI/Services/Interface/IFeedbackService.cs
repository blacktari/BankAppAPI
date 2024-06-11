using System.Threading.Tasks;
using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public interface IFeedbackService
    {
        Task SubmitFeedback(FeedbackRequest feedbackRequest);
    }
}
