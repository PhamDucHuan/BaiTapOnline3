using ISC_Project.DTOs.UserManagement;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UserManagementController : ControllerBase
    {
        private readonly IUserManagementService _userService;

        public UserManagementController(IUserManagementService userService)
        {
            _userService = userService;
        }

        [HttpPost("users")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var createdUser = await _userService.CreateUserAsync(dto);
            return CreatedAtAction(nameof(GetUser), new { userId = createdUser.UserId }, createdUser);
        }

        [HttpGet("users/{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _userService.GetUserByIdAsync(userId);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        //[HttpPut("users/{userId}")]
        //public async Task<IActionResult> UpdateUser(int userId, [FromBody] UpdateUserDto dto)
        //{
        //    if (!ModelState.IsValid) return BadRequest(ModelState);
        //    var updatedUser = await _userService.UpdateUserAsync(userId, dto);
        //    return updatedUser == null ? NotFound() : Ok(updatedUser);
        //}

        //[HttpDelete("users/{userId}")]
        //public async Task<IActionResult> DeleteUser(int userId)
        //{
        //    var success = await _userService.DeleteUserSoftAsync(userId);
        //    return success ? NoContent() : NotFound();
        //}

        [HttpGet("roles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _userService.GetAllRolesAsync();
            return Ok(roles);
        }
    }
}