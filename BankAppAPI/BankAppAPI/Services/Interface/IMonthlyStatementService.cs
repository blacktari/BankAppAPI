using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppApi.Controllers.Domain;

namespace BankAppAPI.Services
{
    public interface IMonthlyStatementService
    {
        Task<IEnumerable<Transaction>> GetMonthlyStatement(string userId, int year, int month);
    }
}
