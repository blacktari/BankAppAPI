using System.Threading.Tasks;

namespace BankAppAPI.Services
{
    public interface IAccountService
    {
        Task<bool> DeactivateAccountAsync(string accountId);
    }
}
