using BankAppAPI.Data.Domain;
using BankAppAPI.Data.Dtos;
using System.Collections.Generic;

namespace BankAppAPI.Services
{
    public interface IBankAccountService
    {
        IEnumerable<BankAccount> GetAll();
        BankAccount GetById(string id);
        void Create(CreateBankAccountDto createBankAccountDto);
        void Deposit(string accountId, decimal amount, string depositBank, string depositAccount);
        void Withdraw(string accountId, decimal amount);
        decimal GetBalance(string accountId);
    }
}
