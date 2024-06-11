// AuditLog.cs
using System;

namespace BankAppAPI.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Reference to the user who performed the action
        public string Action { get; set; } // Description of the action performed
        public DateTime Timestamp { get; set; } // Time when the action was performed
    }
}
