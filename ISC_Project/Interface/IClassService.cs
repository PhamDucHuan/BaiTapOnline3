using ISC_Project.DTOs.Class;

namespace ISC_Project.Interface
{
    public interface IClassService
    {
        Task<ClassDto?> GetByIdAsync(int id);
        Task<IEnumerable<ClassDto>> GetAllAsync();
        Task<ClassDto> CreateAsync(CreateClassDto dto);
    }
}