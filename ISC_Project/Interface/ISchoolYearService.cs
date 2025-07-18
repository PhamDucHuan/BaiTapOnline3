using ISC_Project.DTOs.School_Year;
using ISC_Project.DTOs.SchoolYear;

namespace ISC_Project.Interface
{
    public interface ISchoolYearService
    {
        Task<SchoolYearDto?> GetByIdAsync(int id);
        Task<IEnumerable<SchoolYearDto>> GetAllAsync();
        Task<SchoolYearDto> CreateAsync(CreateSchoolYearDto dto);
        Task<SchoolYearDto> InheritAsync(InheritSchoolYearDto dto);
    }
}