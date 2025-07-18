using ISC_Project.DTOs.Teacher;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class TeacherProfileService : ITeacherProfileService
    {
        private readonly ISC_ProjectDbContext _context;
        public TeacherProfileService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<TeacherProfileDto> CreateAsync(CreateTeacherProfileDto dto)
        {
            var teacher = new TeacherProfile
            {
                TeacherName = dto.TeacherName,
                TeacherCode = dto.TeacherCode,
                Position = dto.Position,
                DateOfBirth = dto.DateOfBirth,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                DepartmentId = dto.Department_ID,
                AdmissionDate = DateTime.UtcNow
            };
            _context.TeacherProfiles.Add(teacher);
            await _context.SaveChangesAsync();
            return new TeacherProfileDto { TeacherId = teacher.TeacherId, TeacherName = teacher.TeacherName, TeacherCode = teacher.TeacherCode, Position = teacher.Position, Status = teacher.Status };
        }

        public async Task<IEnumerable<TeacherProfileDto>> GetAllAsync()
        {
            return await _context.TeacherProfiles
                .Select(t => new TeacherProfileDto { TeacherId = t.TeacherId, TeacherName = t.TeacherName, TeacherCode = t.TeacherCode, Position = t.Position, Status = t.Status })
                .ToListAsync();
        }

        public async Task<TeacherProfileDto?> GetByIdAsync(int id)
        {
            return await _context.TeacherProfiles
                .Where(t => t.TeacherId == id)
                .Select(t => new TeacherProfileDto { TeacherId = t.TeacherId, TeacherName = t.TeacherName, TeacherCode = t.TeacherCode, Position = t.Position, Status = t.Status })
                .FirstOrDefaultAsync();
        }
    }
}