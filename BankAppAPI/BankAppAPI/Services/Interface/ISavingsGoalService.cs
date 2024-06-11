// File: ISavingsGoalService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppAPI.Models;

namespace BankAppAPI.Services
{
    public interface ISavingsGoalService
    {
        Task<IEnumerable<SavingsGoal>> GetSavingsGoalsAsync(string userId);
        Task<SavingsGoal> GetSavingsGoalByIdAsync(int id, string userId);
        Task<SavingsGoal> CreateSavingsGoalAsync(SavingsGoal savingsGoal, string userId);
        Task<SavingsGoal> UpdateSavingsGoalAsync(int id, SavingsGoal savingsGoal, string userId);
        Task<bool> DeleteSavingsGoalAsync(int id, string userId);
    }
}
