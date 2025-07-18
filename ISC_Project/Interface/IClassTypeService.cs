using ISC_Project.DTOs.ClassType;

namespace ISC_Project.Interface
{
    public interface IClassTypeService
    {
        Task<ClassTypeDto?> GetByIdAsync(int id);
        Task<IEnumerable<ClassTypeDto>> GetAllAsync();
        Task<ClassTypeDto> CreateAsync(CreateClassTypeDto dto);
    }
}