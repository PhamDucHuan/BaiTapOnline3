using ISC_Project.DTOs.Subject;

namespace ISC_Project.Interface
{
    public interface ISubjectService
    {
        Task<SubjectDto?> GetByIdAsync(int id);
        Task<IEnumerable<SubjectDto>> GetAllAsync();
        Task<SubjectDto> CreateAsync(CreateSubjectDto dto);
    }
}