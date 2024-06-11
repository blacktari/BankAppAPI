using System.Threading.Tasks;

namespace BankAppAPI.Services
{
    public interface IEmailNotificationService
    {
        Task SendNotificationAsync(string userId, string subject, string message);
    }
}
