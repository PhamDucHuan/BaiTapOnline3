using ISC_Project.DTOs.Student;

namespace ISC_Project.Interface
{
    public interface IStudentProfileService
    {
        Task<StudentProfileDto?> GetByIdAsync(int id);
        Task<IEnumerable<StudentProfileDto>> GetAllAsync();
        Task<StudentProfileDto> CreateAsync(CreateStudentProfileDto dto);
    }
}