using ISC_Project.DTOs.Role;

namespace ISC_Project.Interface
{
    public interface IRoleService
    {
        Task<RoleDto?> GetByIdAsync(int id);
        Task<IEnumerable<RoleDto>> GetAllAsync();
        Task<RoleDto> CreateAsync(CreateRoleDto dto);
    }
}