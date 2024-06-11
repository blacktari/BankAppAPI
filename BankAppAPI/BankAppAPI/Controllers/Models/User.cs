using Microsoft.AspNetCore.Identity;

namespace BankAppAPI.Models
{
    public class User : IdentityUser
    {
        // Additional properties for your user can be added here
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Username { get; internal set; }
    }
}
