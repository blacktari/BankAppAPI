using BankAppApi.Controllers.Domain;
using BankAppAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankAppAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BankAppAPI.Models.AuditLog> AuditLogs { get; set; } // Fully qualify the reference here
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<SavingsGoal> SavingsGoals { get; set; }
    }
}
