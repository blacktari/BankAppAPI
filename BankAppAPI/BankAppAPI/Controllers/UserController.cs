using Microsoft.AspNetCore.Mvc;
using BankAppAPI.Models;
using BankAppAPI.Services;

namespace BankAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuditLogService _auditLogService;

        public UserController(IUserService userService, IAuditLogService auditLogService)
        {
            _userService = userService;
            _auditLogService = auditLogService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(User newUser)
        {
            var createdUser = _userService.CreateUser(newUser);
            if (createdUser == null)
            {
                return BadRequest("Failed to create user");
            }
            _auditLogService.LogAudit(User.Identity.Name, $"Created user with ID: {createdUser.Id}");
            return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deletedUser = _userService.DeleteUser(id);
            if (deletedUser == null)
            {
                return NotFound();
            }
            _auditLogService.LogAudit(User.Identity.Name, $"Deleted user with ID: {deletedUser.Id}");
            return Ok(deletedUser);
        }
    }
}
