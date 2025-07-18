using ISC_Project.DTOs.Teacher;

namespace ISC_Project.Interface
{
    public interface ITeacherProfileService
    {
        Task<TeacherProfileDto?> GetByIdAsync(int id);
        Task<IEnumerable<TeacherProfileDto>> GetAllAsync();
        Task<TeacherProfileDto> CreateAsync(CreateTeacherProfileDto dto);
    }
}