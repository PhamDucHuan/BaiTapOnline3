using ISC_Project.Data;
using ISC_Project.DTOs.Course;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class CourseOfferingService : ICourseOfferingService
    {
        private readonly ISC_ProjectDbContext _context;
        public CourseOfferingService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<CourseOfferingDto> CreateAsync(CreateCourseOfferingDto dto)
        {
            var offering = new CourseOffering
            {
                StarTime = dto.StarTime,
                EndTime = dto.EndTime,
                MaxStudent = dto.MaxStudent,
                Price = dto.Price,
                Status = dto.Status,
                CoursesId = dto.CoursesId,
                InstructorUserId = dto.InstructorUserId
            };
            _context.CourseOfferings.Add(offering);
            await _context.SaveChangesAsync();
            return new CourseOfferingDto { CourseOfferingsId = offering.CourseOfferingsId, Price = (decimal)offering.Price, Status = offering.Status };
        }

        public async Task<IEnumerable<CourseOfferingDto>> GetAllAsync()
        {
            return await _context.CourseOfferings
                .Select(o => new CourseOfferingDto { CourseOfferingsId = o.CourseOfferingsId, Price = (decimal)o.Price, Status = o.Status })
                .ToListAsync();
        }

        public async Task<CourseOfferingDto?> GetByIdAsync(int id)
        {
            return await _context.CourseOfferings
                .Where(o => o.CourseOfferingsId == id)
                .Select(o => new CourseOfferingDto { CourseOfferingsId = o.CourseOfferingsId, Price = (decimal)o.Price, Status = o.Status })
                .FirstOrDefaultAsync();
        }
    }
}
