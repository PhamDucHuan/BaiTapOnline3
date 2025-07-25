using BaiTapOnline3.Models;

namespace BaiTapOnline3.Interface
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetRolesAsync();
        Task<Role> CreateRoleAsync(Role role);
        Task<Role?> UpdateRoleAsync(int id, Role role);
        Task<bool> DeleteRoleAsync(int id);
    }
}
