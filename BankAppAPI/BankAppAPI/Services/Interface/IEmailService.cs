using System.Threading.Tasks;

namespace BankAppAPI.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
