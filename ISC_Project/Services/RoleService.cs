using ISC_Project.DTOs.Role;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ISC_Project.Infrastructure.Services
{
    public class RoleService : IRoleService
    {
        private readonly ISC_ProjectDbContext _context;
        public RoleService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<RoleDto> CreateAsync(CreateRoleDto dto)
        {
            var role = new Role { RoleName = dto.RoleName, Description = dto.Description, IsAdmin = dto.IsAdmin };
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return new RoleDto { RoleId = role.RoleId, RoleName = role.RoleName, IsAdmin = (bool)role.IsAdmin };
        }

        public async Task<IEnumerable<RoleDto>> GetAllAsync()
        {
            return await _context.Roles.Select(r => new RoleDto { RoleId = r.RoleId, RoleName = r.RoleName, IsAdmin = (bool)r.IsAdmin }).ToListAsync();
        }

        public async Task<RoleDto?> GetByIdAsync(int id)
        {
            return await _context.Roles.Where(r => r.RoleId == id).Select(r => new RoleDto { RoleId = r.RoleId, RoleName = r.RoleName, IsAdmin = (bool)r.IsAdmin }).FirstOrDefaultAsync();
        }
    }
}