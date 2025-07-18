using ISC_Project.DTOs.Course;

namespace ISC_Project.Interface
{
    public interface ICourseService
    {
        Task<CourseDto?> GetByIdAsync(int id);
        Task<IEnumerable<CourseDto>> GetAllAsync();
        Task<CourseDto> CreateAsync(CreateCourseDto dto);
    }
}