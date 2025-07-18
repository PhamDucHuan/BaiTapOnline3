using ISC_Project.DTOs.Subject;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISC_ProjectDbContext _context;
        public SubjectService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<SubjectDto> CreateAsync(CreateSubjectDto dto)
        {
            var subject = new Subject
            {
                SubjectsName = dto.SubjectsName,
                SubjectCode = dto.SubjectCode,
                DepartmentId = dto.DepartmentId,
                // Gán các giá trị mặc định khác nếu cần
                StarTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddMonths(3)
            };
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return new SubjectDto { SubjectsId = subject.SubjectsId, SubjectsName = subject.SubjectsName, SubjectCode = subject.SubjectCode };
        }

        public async Task<IEnumerable<SubjectDto>> GetAllAsync()
        {
            return await _context.Subjects
                .Select(s => new SubjectDto { SubjectsId = s.SubjectsId, SubjectsName = s.SubjectsName, SubjectCode = s.SubjectCode })
                .ToListAsync();
        }

        public async Task<SubjectDto?> GetByIdAsync(int id)
        {
            return await _context.Subjects
                .Where(s => s.SubjectsId == id)
                .Select(s => new SubjectDto { SubjectsId = s.SubjectsId, SubjectsName = s.SubjectsName, SubjectCode = s.SubjectCode })
                .FirstOrDefaultAsync();
        }
    }
}