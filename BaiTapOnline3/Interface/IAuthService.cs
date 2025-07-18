using BaiTapOnline3.Controllers;
using BaiTapOnline3.DTOs;

namespace BaiTapOnline3.Interface
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginModel loginModel);
    }
}
