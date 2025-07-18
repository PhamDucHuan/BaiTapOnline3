using ISC_Project.DTOs.Course;
using ISC_Project.Interface;
using ISC_Project.Data;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Infrastructure.Services
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ISC_ProjectDbContext _context;
        public CourseCategoryService(ISC_ProjectDbContext context) { _context = context; }

        public async Task<CourseCategoryDto> CreateAsync(CreateCourseCategoryDto dto)
        {
            var category = new CourseCategory
            {
                CourseCategoriesName = dto.CourseCategoriesName,
                Description = dto.Description
            };
            _context.CourseCategories.Add(category);
            await _context.SaveChangesAsync();
            return new CourseCategoryDto { CourseCategoriesId = category.CourseCategoriesId, CourseCategoriesName = category.CourseCategoriesName };
        }

        public async Task<IEnumerable<CourseCategoryDto>> GetAllAsync()
        {
            return await _context.CourseCategories
                .Select(c => new CourseCategoryDto { CourseCategoriesId = c.CourseCategoriesId, CourseCategoriesName = c.CourseCategoriesName })
                .ToListAsync();
        }

        public async Task<CourseCategoryDto?> GetByIdAsync(int id)
        {
            return await _context.CourseCategories
                .Where(c => c.CourseCategoriesId == id)
                .Select(c => new CourseCategoryDto { CourseCategoriesId = c.CourseCategoriesId, CourseCategoriesName = c.CourseCategoriesName })
                .FirstOrDefaultAsync();
        }
    }
}