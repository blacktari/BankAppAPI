using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankAppAPI.Services;
using BankAppAPI.Models;

namespace BankAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionHistoryController : ControllerBase
    {
        private readonly ITransactionHistoryService _transactionHistoryService;

        public TransactionHistoryController(ITransactionHistoryService transactionHistoryService)
        {
            _transactionHistoryService = transactionHistoryService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetTransactionHistory(string userId, int pageNumber = 1, int pageSize = 10)
        {
            var transactions = await _transactionHistoryService.GetTransactionHistoryAsync(userId, pageNumber, pageSize);
            return Ok(transactions);
        }
    }
}
