using BaiTapOnline3.Models;

namespace BaiTapOnline3.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<object>> GetUsersAsync();
        Task<object> GetUserAsync(int id);
        Task<User> CreateUserAsync(User user);
        Task<bool> UpdateUserAsync(int id, User user);
        Task<bool> DeleteUserAsync(int id);
    }
}
