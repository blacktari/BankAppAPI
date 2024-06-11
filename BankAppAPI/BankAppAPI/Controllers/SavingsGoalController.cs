// File: SavingsGoalController.cs
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppAPI.Models;
using BankAppAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankAppAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class SavingsGoalController : ControllerBase
    {
        private readonly ISavingsGoalService _savingsGoalService;

        public SavingsGoalController(ISavingsGoalService savingsGoalService)
        {
            _savingsGoalService = savingsGoalService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingsGoal>>> GetSavingsGoals()
        {
            var userId = User.Identity.Name;
            var savingsGoals = await _savingsGoalService.GetSavingsGoalsAsync(userId);
            return Ok(savingsGoals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SavingsGoal>> GetSavingsGoal(int id)
        {
            var userId = User.Identity.Name;
            var savingsGoal = await _savingsGoalService.GetSavingsGoalByIdAsync(id, userId);

            if (savingsGoal == null)
            {
                return NotFound();
            }

            return Ok(savingsGoal);
        }

        [HttpPost]
        public async Task<ActionResult<SavingsGoal>> CreateSavingsGoal(SavingsGoal savingsGoal)
        {
            var userId = User.Identity.Name;
            var createdSavingsGoal = await _savingsGoalService.CreateSavingsGoalAsync(savingsGoal, userId);
            return CreatedAtAction(nameof(GetSavingsGoal), new { id = createdSavingsGoal.Id }, createdSavingsGoal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSavingsGoal(int id, SavingsGoal savingsGoal)
        {
            var userId = User.Identity.Name;
            var result = await _savingsGoalService.UpdateSavingsGoalAsync(id, savingsGoal, userId);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavingsGoal(int id)
        {
            var userId = User.Identity.Name;
            var result = await _savingsGoalService.DeleteSavingsGoalAsync(id, userId);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
