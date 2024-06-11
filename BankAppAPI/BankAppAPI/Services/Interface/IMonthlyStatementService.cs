using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public interface IMonthlyStatementService
    {
        Task<IEnumerable<Transaction>> GetMonthlyStatement(string userId, int year, int month);
    }
}
