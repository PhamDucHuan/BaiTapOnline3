using ISC_Project.DTOs.ClassType;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class ClassTypeService : IClassTypeService
    {
        private readonly ISC_ProjectDbContext _context;
        public ClassTypeService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<ClassTypeDto> CreateAsync(CreateClassTypeDto dto)
        {
            var classType = new ClassType
            {
                ClassTypeName = dto.ClassTypeName,
                Note = dto.Note,
                Status = dto.Status
            };
            _context.ClassTypes.Add(classType);
            await _context.SaveChangesAsync();
            return new ClassTypeDto { ClassTypeId = classType.ClassTypeId, ClassTypeName = classType.ClassTypeName };
        }

        public async Task<IEnumerable<ClassTypeDto>> GetAllAsync()
        {
            return await _context.ClassTypes
                .Select(ct => new ClassTypeDto { ClassTypeId = ct.ClassTypeId, ClassTypeName = ct.ClassTypeName })
                .ToListAsync();
        }

        public async Task<ClassTypeDto?> GetByIdAsync(int id)
        {
            return await _context.ClassTypes
                .Where(ct => ct.ClassTypeId == id)
                .Select(ct => new ClassTypeDto { ClassTypeId = ct.ClassTypeId, ClassTypeName = ct.ClassTypeName })
                .FirstOrDefaultAsync();
        }
    }
}