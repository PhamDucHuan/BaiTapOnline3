using BaiTapOnline3.DTOs;
using BaiTapOnline3.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapOnline3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var tokenString = await _authService.LoginAsync(loginModel);

            if (tokenString == null)
            {
                return Unauthorized("Tên đăng nhập hoặc mật khẩu không đúng.");
            }

            return Ok(new { Token = tokenString });
        }
    }
}