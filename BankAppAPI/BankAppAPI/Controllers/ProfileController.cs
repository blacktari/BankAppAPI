using BankAppAPI.Data.Dtos;
using BankAppAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BankAppAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserProfile(string id)
        {
            var userProfile = _profileService.GetUserProfile(id);
            if (userProfile == null)
            {
                return NotFound();
            }
            return Ok(userProfile);
        }

        [HttpPost]
        public IActionResult CreateUserProfile([FromBody] UserProfileDto userProfileDto)
        {
            try
            {
                var userProfile = _profileService.CreateUserProfile(userProfileDto);
                return CreatedAtAction(nameof(GetUserProfile), new { id = userProfile.Id }, userProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserProfile(string id, [FromBody] UserProfileDto userProfileDto)
        {
            try
            {
                var userProfile = _profileService.UpdateUserProfile(id, userProfileDto);
                if (userProfile == null)
                {
                    return NotFound();
                }
                return Ok(userProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserProfile(string id)
        {
            try
            {
                var userProfile = _profileService.DeleteUserProfile(id);
                if (userProfile == null)
                {
                    return NotFound();
                }
                return Ok(userProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
