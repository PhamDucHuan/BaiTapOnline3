using ISC_Project.DTOs.Department;
using ISC_Project.Interface;
using ISC_Project.Data;

using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class TeamDepartmentService : ITeamDepartmentService
    {
        private readonly ISC_ProjectDbContext _context;
        public TeamDepartmentService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto)
        {
            var department = new TeamDepartment
            {
                DepartmentName = dto.DepartmentName,
                SchoolId = dto.SchoolId
                // Other required properties should be set here if any
            };
            _context.TeamDepartments.Add(department);
            await _context.SaveChangesAsync();
            return new DepartmentDto { DepartmentId = department.DepartmentId, DepartmentName = department.DepartmentName };
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllAsync()
        {
            return await _context.TeamDepartments.Select(d => new DepartmentDto { DepartmentId = d.DepartmentId, DepartmentName = d.DepartmentName }).ToListAsync();
        }

        public async Task<DepartmentDto?> GetByIdAsync(int id)
        {
            return await _context.TeamDepartments.Where(d => d.DepartmentId == id).Select(d => new DepartmentDto { DepartmentId = d.DepartmentId, DepartmentName = d.DepartmentName }).FirstOrDefaultAsync();
        }
    }
}