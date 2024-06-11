using BankAppAPI.Data.Domain;
using BankAppAPI.Models;
using EntityFramework.Audit;
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
        public DbSet<BankAppAPI.Models.Transaction> Transactions { get; set; } // Fully qualify Transaction class
        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}
