using ISC_Project.DTOs.School;

namespace ISC_Project.Interface
{
    public interface ISchoolProfileService
    {
        Task<SchoolProfileDto?> GetByIdAsync(int id);
        Task<IEnumerable<SchoolProfileDto>> GetAllAsync();
        Task<SchoolProfileDto> CreateAsync(CreateSchoolProfileDto dto);
    }
}