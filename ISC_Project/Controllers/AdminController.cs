using ISC_Project.Interface.AuthService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ISC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")] // Chỉ Admin mới vào được controller này
    public class AdminController : ControllerBase
    {
        private readonly IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("users/{targetUserId}/role")]
        public async Task<IActionResult> UpdateUserRole(int targetUserId, [FromBody] UpdateRoleRequestDto request)
        {
            try
            {
                // Lấy ID của Admin đang đăng nhập từ token
                var currentUserIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(currentUserIdString))
                {
                    return Unauthorized("Không thể xác định người dùng.");
                }
                var currentUserId = int.Parse(currentUserIdString);

                // Gọi service với đầy đủ tham số
                await _userService.UpdateUserRoleAsync(targetUserId, request.NewRoleId, currentUserId);

                return Ok(new { message = "Cập nhật vai trò thành công." });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message }); // 404 Not Found
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message }); // 400 Bad Request
            }
        }
    }
}

// DTO cho request body
public class UpdateRoleRequestDto
{
    public int NewRoleId { get; set; }
}