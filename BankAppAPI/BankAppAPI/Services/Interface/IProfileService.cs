using BankAppAPI.Data.Dtos;

namespace BankAppAPI.Services
{
    public interface IProfileService
    {
        UserProfileDto GetUserProfile(string id);
        UserProfileDto CreateUserProfile(UserProfileDto userProfileDto);
        UserProfileDto UpdateUserProfile(string id, UserProfileDto userProfileDto);
        UserProfileDto DeleteUserProfile(string id);
    }
}
