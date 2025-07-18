using ISC_Project.Data;
using ISC_Project.DTOs.UserManagement;
using ISC_Project.Interface.AuthService;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
namespace ISC_Project.Services.AuthService  
{
    public class AuthService : IAuthService
    {
        private readonly ISC_ProjectDbContext _context;
        private readonly IJwtService _jwtService; // ✅ TIÊM IJwtService VÀO

        private readonly string _jwtKey; // ✅ BIẾN MỚI ĐỂ LƯU KEY
        public AuthService(ISC_ProjectDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService; // ✅
        }

        public async Task<LoginResultDto> LoginAsync(LoginRequestDto request)
        {
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserName == request.Username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
            {
                throw new UnauthorizedAccessException("Tên đăng nhập hoặc mật khẩu không hợp lệ.");
            }

            // ✅ GỌI JwtService ĐỂ TẠO TOKEN
            var accessToken = _jwtService.CreateAccessToken(user);

            var refreshToken = _jwtService.CreateRefreshToken();

            user.Token = refreshToken;
            await _context.SaveChangesAsync();

            UserDataDto userData = new UserDataDto(
                user.UserId, user.UserName, user.FullName, user.Email, user.Role.RoleName
            );

            return new LoginResultDto(accessToken, refreshToken, userData);
        }

        public async Task<TokenResponseDto> RefreshTokenAsync(RefreshRequestDto request)
        {
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Token == request.RefreshToken);

            if (user == null)
            {
                throw new ArgumentException("Refresh token không hợp lệ.");
            }

            // ✅ GỌI JwtService ĐỂ TẠO TOKEN MỚI
            var newAccessToken = _jwtService.CreateAccessToken(user);
            var newRefreshToken = _jwtService.CreateRefreshToken();

            user.Token = newRefreshToken;
            await _context.SaveChangesAsync();

            return new TokenResponseDto(newAccessToken, newRefreshToken);
        }

        public async Task<User> RegisterAsync(RegisterRequestDto request)
        {
            // 1. Kiểm tra xem username đã tồn tại chưa
            if (await _context.Users.AnyAsync(u => u.UserName == request.Username))
            {
                throw new ArgumentException("Tên đăng nhập đã tồn tại.");
            }

            // 2. Mã hóa mật khẩu
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);

            // 3. Tạo đối tượng User mới
            // Mặc định gán vai trò là "Student" (ID = 3 theo thiết kế trước)
            // Bạn có thể thay đổi logic này nếu cần
            var newUser = new User
            {
                UserName = request.Username,
                Password = hashedPassword,
                FullName = request.FullName, // Giả sử bạn có cột FullName trong bảng User
                Email = request.Email,       // Giả sử bạn có cột Email
                RoleId = 3, // Mặc định là Student
                Status = "Active", // Mặc định
                CreateAt = DateTime.UtcNow
            };

            // 4. Lưu vào cơ sở dữ liệu
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }

    }
}
