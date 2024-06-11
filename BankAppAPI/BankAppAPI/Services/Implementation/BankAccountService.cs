using BankAppAPI.Data;
using BankAppAPI.Data.Domain;
using BankAppAPI.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAppAPI.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly ApplicationDbContext _context;

        public BankAccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BankAccount> GetAll()
        {
            return _context.BankAccounts.ToList();
        }

        public BankAccount GetById(string id)
        {
            return _context.BankAccounts.Find(id);
        }

        public void Create(CreateBankAccountDto createBankAccountDto)
        {
            if (!DateTime.TryParseExact(createBankAccountDto.DateOfBirth, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dateOfBirth))
            {
                throw new ArgumentException("Invalid date format. Use yyyy-MM-dd.");
            }

            var account = new BankAccount
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = createBankAccountDto.FirstName,
                LastName = createBankAccountDto.LastName,
                MiddleName = createBankAccountDto.MiddleName,
                Address = createBankAccountDto.Address,
                PhoneNumber = createBankAccountDto.PhoneNumber,
                Email = createBankAccountDto.Email,
                DateOfBirth = dateOfBirth,
                NextOfKinName = createBankAccountDto.NextOfKinName,
                NextOfKinPhoneNumber = createBankAccountDto.NextOfKinPhoneNumber,
                AccountType = createBankAccountDto.AccountType,
                Country = createBankAccountDto.Country,
                PostalCode = createBankAccountDto.PostalCode,
                StateOfOrigin = createBankAccountDto.StateOfOrigin, // New property
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(createBankAccountDto.Password),
                Balance = 0m,
                CreatedAt = DateTime.UtcNow
            };

            _context.BankAccounts.Add(account);
            _context.SaveChanges();
        }

        public void Deposit(string accountId, decimal amount, string depositBank, string depositAccount)
        {
            var account = _context.BankAccounts.Find(accountId);
            if (account != null)
            {
                account.Balance += amount;
                _context.SaveChanges();
            }
        }

        public void Withdraw(string accountId, decimal amount)
        {
            var account = _context.BankAccounts.Find(accountId);
            if (account != null && account.Balance >= amount)
            {
                account.Balance -= amount;
                _context.SaveChanges();
            }
        }

        public decimal GetBalance(string accountId)
        {
            var account = _context.BankAccounts.Find(accountId);
            return account?.Balance ?? 0;
        }
    }
}
