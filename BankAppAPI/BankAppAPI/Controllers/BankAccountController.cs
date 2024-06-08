using BankAppAPI.Data.Dtos;
using BankAppAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BankAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateBankAccountDto createBankAccountDto)
        {
            _bankAccountService.Create(createBankAccountDto);
            return Ok();
        }

        [HttpPost("deposit")]
        public IActionResult Deposit(string accountId, decimal amount, string depositBank, string depositAccount)
        {
            _bankAccountService.Deposit(accountId, amount, depositBank, depositAccount);
            return Ok();
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw(string accountId, decimal amount)
        {
            _bankAccountService.Withdraw(accountId, amount);
            return Ok();
        }

        [HttpGet("balance/{accountId}")]
        public IActionResult GetBalance(string accountId)
        {
            var balance = _bankAccountService.GetBalance(accountId);
            return Ok(balance);
        }
    }
}
