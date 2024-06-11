// IAuditLogService.cs
using System.Collections.Generic;
using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public interface IAuditLogService
    {
        void LogAudit(string userId, string action);
        IEnumerable<AuditLog> GetAuditLogs();
    }
}
