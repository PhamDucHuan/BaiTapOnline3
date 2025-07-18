using BaiTapOnline3.Models;

namespace BaiTapOnline3.Interface
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetRolesAsync();
        Task<Role> CreateRoleAsync(Role role);
    }
}
