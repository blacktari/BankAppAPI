namespace BankAppAPI.Services
{
    public interface IAuthService
    {
        string Login(string email, string password);
    }
}
