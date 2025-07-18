using ISC_Project.DTOs.Exemption;
using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IExemptionService
    {
        Task<Exemption?> GetByIdAsync(int exemptionId);
        Task<IEnumerable<Exemption>> GetAllAsync();
        Task<Exemption> CreateAsync(CreateExemptionDto dto);
        Task<Exemption?> UpdateAsync(int exemptionId, CreateExemptionDto dto);
        Task<bool> DeleteAsync(int exemptionId);
    }
}
