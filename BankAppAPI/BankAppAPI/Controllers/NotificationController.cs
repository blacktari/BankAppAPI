using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAppAPI.Services;

namespace BankAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly IEmailNotificationService _emailNotificationService;

        public NotificationController(IEmailNotificationService emailNotificationService)
        {
            _emailNotificationService = emailNotificationService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] NotificationRequest request)
        {
            await _emailNotificationService.SendNotificationAsync(request.UserId, request.Subject, request.Message);
            return Ok(new { message = "Notification sent successfully." });
        }
    }

    public class NotificationRequest
    {
        public string UserId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
