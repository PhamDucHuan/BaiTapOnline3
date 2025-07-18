using ISC_Project.DTOs.Course;

namespace ISC_Project.Interface
{
    public interface ICourseCategoryService
    {
        Task<CourseCategoryDto?> GetByIdAsync(int id);
        Task<IEnumerable<CourseCategoryDto>> GetAllAsync();
        Task<CourseCategoryDto> CreateAsync(CreateCourseCategoryDto dto);
    }
}