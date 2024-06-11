// AuditLogService.cs
using System;
using System.Collections.Generic;
using BankAppAPI.Data;
using BankAppAPI.Models;

namespace BankAppAPI.Services.Implementation
{
    public class AuditLogService : IAuditLogService
    {
        private readonly ApplicationDbContext _context;

        public AuditLogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void LogAudit(string userId, string action)
        {
            var auditLog = new AuditLog
            {
                UserId = userId,
                Action = action,
                Timestamp = DateTime.UtcNow
            };

            _context.AuditLogs.Add(auditLog);
            _context.SaveChanges();
        }

        public IEnumerable<AuditLog> GetAuditLogs()
        {
            return _context.AuditLogs;
        }
    }
}
