using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        User CreateUser(User newUser);
        User DeleteUser(int id);
    }
}
