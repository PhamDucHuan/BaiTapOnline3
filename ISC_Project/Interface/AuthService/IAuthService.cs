using ISC_Project.DTOs.UserManagement;
using ISC_Project.Models;

namespace ISC_Project.Interface.AuthService
{
    public record LoginRequestDto(string Username, string Password);
    public record TokenResponseDto(string AccessToken, string RefreshToken);
    public record RefreshRequestDto(string RefreshToken);

    public record UserDataDto(int UserId, string Username, string FullName, string Email, string Role);
    public record LoginResultDto(string AccessToken, string RefreshToken, UserDataDto UserData);
    public interface IAuthService
    {
        Task<LoginResultDto> LoginAsync(LoginRequestDto request);

        Task<TokenResponseDto> RefreshTokenAsync(RefreshRequestDto request);
        Task<User> RegisterAsync(RegisterRequestDto request);
    }
}
