using BaiTapOnline3.Data;
using BaiTapOnline3.Interface;
using BaiTapOnline3.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapOnline3.Services
{
    public class RoleService : IRoleService
    {
        private readonly Project_Online3DBContext _context;

        public RoleService(Project_Online3DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> CreateRoleAsync(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }
        public async Task<Role?> UpdateRoleAsync(int id, Role role)
        {
            var existingRole = await _context.Roles.FindAsync(id);
            if (existingRole == null)
                return null;

            existingRole.RoleName = role.RoleName;
            await _context.SaveChangesAsync();
            return existingRole;
        }

        public async Task<bool> DeleteRoleAsync(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role == null)
                return false;

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}