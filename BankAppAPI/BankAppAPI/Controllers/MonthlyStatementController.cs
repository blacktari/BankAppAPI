using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppAPI.Services;
using BankAppApi.Controllers.Domain;

namespace BankAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonthlyStatementController : ControllerBase
    {
        private readonly IMonthlyStatementService _monthlyStatementService;

        public MonthlyStatementController(IMonthlyStatementService monthlyStatementService)
        {
            _monthlyStatementService = monthlyStatementService;
        }

        [HttpGet("{userId}/{year}/{month}")]
        public async Task<IActionResult> GetMonthlyStatement(string userId, int year, int month)
        {
            try
            {
                IEnumerable<Transaction> monthlyStatement = await _monthlyStatementService.GetMonthlyStatement(userId, year, month);
                return Ok(monthlyStatement);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
