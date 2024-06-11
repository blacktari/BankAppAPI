using BankAppAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("deactivate")]
        public async Task<IActionResult> DeactivateAccount(string accountId)
        {
            var result = await _accountService.DeactivateAccountAsync(accountId);
            if (result)
            {
                return Ok("Account deactivated successfully.");
            }
            return NotFound("Account not found.");
        }
    }
}
