using Microsoft.EntityFrameworkCore;
using BankAppAPI.Models;
using BankAppAPI.Data.Domain;
using Microsoft.Azure.Documents;

namespace BankAppAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; } // Assuming there's a User entity for authentication
    }
}
