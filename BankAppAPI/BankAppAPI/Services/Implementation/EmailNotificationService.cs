using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankAppAPI.Data;
using BankAppAPI.Models;
using NETCore.MailKit.Core;

namespace BankAppAPI.Services
{
    public class EmailNotificationService : IEmailNotificationService
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public EmailNotificationService(ApplicationDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public async Task SendNotificationAsync(string userId, string subject, string message)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                await _emailService.SendEmailAsync(user.Email, subject, message);
            }
        }
    }
}
