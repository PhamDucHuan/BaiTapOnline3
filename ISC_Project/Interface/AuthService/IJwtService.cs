using ISC_Project.Models;

namespace ISC_Project.Interface.AuthService
{
    public interface IJwtService
    {
        string CreateAccessToken(User user);
        string CreateRefreshToken();
    }
}
