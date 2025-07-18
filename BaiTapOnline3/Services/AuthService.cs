using BaiTapOnline3.Controllers;
using BaiTapOnline3.Data;
using BaiTapOnline3.DTOs;
using BaiTapOnline3.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BaiTapOnline3.Services
{
    public class AuthService : IAuthService
    {
        private readonly Project_Online3DBContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(Project_Online3DBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == loginModel.Username);

            // TODO: Thay thế bằng cơ chế so sánh mật khẩu đã hash an toàn
            if (user == null || user.PasswordHash != loginModel.Password)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.RoleId.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}