using BankAppAPI.Data;
using BankAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BankAppAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _context;

        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeactivateAccountAsync(string accountId)
        {
            var account = await _context.BankAccounts.FirstOrDefaultAsync(a => a.Id == accountId);
            if (account != null)
            {
                account.IsActive = false;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
