using ISC_Project.DTOs.Student;
using ISC_Project.Interface;
using ISC_Project.Data;

using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class StudentProfileService : IStudentProfileService
    {
        private readonly ISC_ProjectDbContext _context;
        public StudentProfileService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<StudentProfileDto> CreateAsync(CreateStudentProfileDto dto)
        {
            var student = new StudentsProfile
            {
                StudentName = dto.StudentName,
                StudentCode = dto.StudentCode,
                DateOfBirth = dto.DateOfBirth,
                Status = dto.Status,
                ClassId = dto.ClassId,
                AdmissionDate = DateTime.UtcNow
            };

            _context.StudentsProfiles.Add(student);
            await _context.SaveChangesAsync();

            return new StudentProfileDto
            {
                StudentsProfileId = student.StudentsProfileId,
                StudentName = student.StudentName,
                StudentCode = student.StudentCode,
                Status = student.Status
            };
        }

        public async Task<IEnumerable<StudentProfileDto>> GetAllAsync()
        {
            return await _context.StudentsProfiles
                .Select(s => new StudentProfileDto
                {
                    StudentsProfileId = s.StudentsProfileId,
                    StudentName = s.StudentName,
                    StudentCode = s.StudentCode,
                    Status = s.Status
                })
                .ToListAsync();
        }

        public async Task<StudentProfileDto?> GetByIdAsync(int id)
        {
            return await _context.StudentsProfiles
                .Where(s => s.StudentsProfileId == id)
                .Select(s => new StudentProfileDto
                {
                    StudentsProfileId = s.StudentsProfileId,
                    StudentName = s.StudentName,
                    StudentCode = s.StudentCode,
                    Status = s.Status
                })
                .FirstOrDefaultAsync();
        }
    }
}