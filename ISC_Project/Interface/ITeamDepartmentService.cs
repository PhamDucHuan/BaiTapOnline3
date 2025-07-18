using ISC_Project.DTOs.Department;

namespace ISC_Project.Interface
{
    public interface ITeamDepartmentService
    {
        Task<DepartmentDto?> GetByIdAsync(int id);
        Task<IEnumerable<DepartmentDto>> GetAllAsync();
        Task<DepartmentDto> CreateAsync(CreateDepartmentDto dto);
    }
}