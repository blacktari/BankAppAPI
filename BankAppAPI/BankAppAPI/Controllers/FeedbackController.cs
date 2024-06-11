using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankAppAPI.Models;
using BankAppAPI.Services;

namespace BankAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpPost]
        public async Task<IActionResult> PostFeedback(FeedbackRequest feedbackRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _feedbackService.SubmitFeedback(feedbackRequest);
            return Ok();
        }
    }
}
