using ISC_Project.Data;
using ISC_Project.DTOs.Course;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class CourseService : ICourseService
    {
        private readonly ISC_ProjectDbContext _context;
        public CourseService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<CourseDto> CreateAsync(CreateCourseDto dto)
        {
            var course = new Course
            {
                Title = dto.Title,
                Description = dto.Description,
                DefaultPrice = dto.DefaultPrice,
                CourseCategoriesId = dto.CourseCategoriesId
            };
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return new CourseDto { CoursesId = course.CoursesId, Title = course.Title, DefaultPrice = (decimal)course.DefaultPrice };
        }

        public async Task<IEnumerable<CourseDto>> GetAllAsync()
        {
            return await _context.Courses
                .Select(c => new CourseDto { CoursesId = c.CoursesId, Title = c.Title, DefaultPrice = (decimal)c.DefaultPrice })
                .ToListAsync();
        }

        public async Task<CourseDto?> GetByIdAsync(int id)
        {
            return await _context.Courses
                .Where(c => c.CoursesId == id)
                .Select(c => new CourseDto { CoursesId = c.CoursesId, Title = c.Title, DefaultPrice = (decimal)c.DefaultPrice })
                .FirstOrDefaultAsync();
        }
    }
}
