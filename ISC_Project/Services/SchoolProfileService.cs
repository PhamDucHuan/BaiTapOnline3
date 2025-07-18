using ISC_Project.DTOs.School;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class SchoolProfileService : ISchoolProfileService
    {
        private readonly ISC_ProjectDbContext _context;
        public SchoolProfileService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<SchoolProfileDto> CreateAsync(CreateSchoolProfileDto dto)
        {
            var school = new SchoolProfile
            {
                SchoolName = dto.SchoolName,
                SchoolCode = dto.SchoolCode,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber
            };

            _context.SchoolProfiles.Add(school);
            await _context.SaveChangesAsync();

            return new SchoolProfileDto
            {
                SchoolId = school.SchoolId,
                SchoolName = school.SchoolName,
                SchoolCode = school.SchoolCode,
                Email = school.Email
            };
        }

        public async Task<IEnumerable<SchoolProfileDto>> GetAllAsync()
        {
            return await _context.SchoolProfiles.Select(s => new SchoolProfileDto
            {
                SchoolId = s.SchoolId,
                SchoolName = s.SchoolName,
                SchoolCode = s.SchoolCode,
                Email = s.Email
            }).ToListAsync();
        }

        public async Task<SchoolProfileDto?> GetByIdAsync(int id)
        {
            return await _context.SchoolProfiles.Where(s => s.SchoolId == id)
                .Select(s => new SchoolProfileDto
                {
                    SchoolId = s.SchoolId,
                    SchoolName = s.SchoolName,
                    SchoolCode = s.SchoolCode,
                    Email = s.Email
                }).FirstOrDefaultAsync();
        }
    }
}