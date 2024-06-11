// File: SavingsGoalService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAppAPI.Data;
using BankAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAppAPI.Services.Implementation
{
    public class SavingsGoalService : ISavingsGoalService
    {
        private readonly ApplicationDbContext _context;

        public SavingsGoalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SavingsGoal>> GetSavingsGoalsAsync(string userId)
        {
            return await _context.SavingsGoals.Where(s => s.UserId == userId).ToListAsync();
        }

        public async Task<SavingsGoal> GetSavingsGoalByIdAsync(int id, string userId)
        {
            return await _context.SavingsGoals.FirstOrDefaultAsync(s => s.Id == id && s.UserId == userId);
        }

        public async Task<SavingsGoal> CreateSavingsGoalAsync(SavingsGoal savingsGoal, string userId)
        {
            savingsGoal.UserId = userId;
            savingsGoal.CreatedAt = DateTime.Now;

            _context.SavingsGoals.Add(savingsGoal);
            await _context.SaveChangesAsync();

            return savingsGoal;
        }

        public async Task<SavingsGoal> UpdateSavingsGoalAsync(int id, SavingsGoal savingsGoal, string userId)
        {
            var existingGoal = await _context.SavingsGoals.FirstOrDefaultAsync(s => s.Id == id && s.UserId == userId);

            if (existingGoal == null)
            {
                return null;
            }

            existingGoal.Name = savingsGoal.Name;
            existingGoal.TargetAmount = savingsGoal.TargetAmount;
            existingGoal.TargetDate = savingsGoal.TargetDate;

            _context.SavingsGoals.Update(existingGoal);
            await _context.SaveChangesAsync();

            return existingGoal;
        }

        public async Task<bool> DeleteSavingsGoalAsync(int id, string userId)
        {
            var existingGoal = await _context.SavingsGoals.FirstOrDefaultAsync(s => s.Id == id && s.UserId == userId);

            if (existingGoal == null)
            {
                return false;
            }

            _context.SavingsGoals.Remove(existingGoal);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
