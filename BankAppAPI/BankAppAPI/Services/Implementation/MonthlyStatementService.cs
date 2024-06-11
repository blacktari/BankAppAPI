using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAppAPI.Data;
using BankAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAppAPI.Services
{
    public class MonthlyStatementService : IMonthlyStatementService
    {
        private readonly ApplicationDbContext _context;

        public MonthlyStatementService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transaction>> GetMonthlyStatement(string userId, int year, int month)
        {
            return await _context.Transactions
                .Where(t => t.UserId == userId && t.Date.Year == year && t.Date.Month == month)
                .ToListAsync();
        }
    }
}
