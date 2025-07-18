using ISC_Project.DTOs.Class;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class ClassService : IClassService
    {
        private readonly ISC_ProjectDbContext _context;
        public ClassService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<ClassDto> CreateAsync(CreateClassDto dto)
        {
            var newClass = new Class
            {
                ClassName = dto.ClassName,
                ClassCode = dto.ClassCode,
                DepartmentId = dto.DepartmentId,
                ClassTypeId = dto.ClassTypeId,
                // Gán các giá trị mặc định khác nếu cần
                StarTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddMonths(3) // Ví dụ
            };
            _context.Classes.Add(newClass);
            await _context.SaveChangesAsync();
            return new ClassDto { ClassId = newClass.ClassId, ClassName = newClass.ClassName, ClassCode = newClass.ClassCode };
        }

        public async Task<IEnumerable<ClassDto>> GetAllAsync()
        {
            return await _context.Classes
                .Select(c => new ClassDto { ClassId = c.ClassId, ClassName = c.ClassName, ClassCode = c.ClassCode })
                .ToListAsync();
        }

        public async Task<ClassDto?> GetByIdAsync(int id)
        {
            return await _context.Classes
                .Where(c => c.ClassId == id)
                .Select(c => new ClassDto { ClassId = c.ClassId, ClassName = c.ClassName, ClassCode = c.ClassCode })
                .FirstOrDefaultAsync();
        }
    }
}