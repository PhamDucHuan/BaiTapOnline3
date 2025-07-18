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
    }
}