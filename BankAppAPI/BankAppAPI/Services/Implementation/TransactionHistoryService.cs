using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAppAPI.Data;
using BankAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAppAPI.Services
{
    public class TransactionHistoryService : ITransactionHistoryService
    {
        private readonly ApplicationDbContext _context;

        public TransactionHistoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TransactionDto>> GetTransactionHistoryAsync(string userId, int pageNumber, int pageSize)
        {
            var transactions = await _context.Transactions
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.Date)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    Amount = t.Amount,
                    Date = t.Date,
                    Description = t.Description
                })
                .ToListAsync();

            return transactions;
        }
    }
}
