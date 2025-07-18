using ISC_Project.DTOs.Course;

namespace ISC_Project.Interface
{
    public interface ICourseOfferingService
    {
        Task<CourseOfferingDto?> GetByIdAsync(int id);
        Task<IEnumerable<CourseOfferingDto>> GetAllAsync();
        Task<CourseOfferingDto> CreateAsync(CreateCourseOfferingDto dto);
    }
}