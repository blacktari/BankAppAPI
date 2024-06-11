using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public interface ITransactionHistoryService
    {
        Task<IEnumerable<TransactionDto>> GetTransactionHistoryAsync(string userId, int pageNumber, int pageSize);
    }
}
