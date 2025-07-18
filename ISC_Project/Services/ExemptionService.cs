using ISC_Project.Data;
using ISC_Project.DTOs.Exemption;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class ExemptionService : IExemptionService
    {
        private readonly ISC_ProjectDbContext _context;

        public ExemptionService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<Exemption?> GetByIdAsync(int exemptionId) => await _context.Exemptions.FindAsync(exemptionId);

        public async Task<IEnumerable<Exemption>> GetAllAsync() => await _context.Exemptions.AsNoTracking().ToListAsync();

        public async Task<Exemption> CreateAsync(CreateExemptionDto dto)
        {
            var newExemption = new Exemption
            {
                UserId = dto.UserId,
                ClassId = dto.ClassId,
                ExemptionObjects = dto.ExemptionObjects,
                FormExemption = dto.FormExemption
            };
            _context.Exemptions.Add(newExemption);
            await _context.SaveChangesAsync();
            return newExemption;
        }

        public async Task<Exemption?> UpdateAsync(int exemptionId, CreateExemptionDto dto)
        {
            var exemption = await _context.Exemptions.FindAsync(exemptionId);
            if (exemption == null) return null;

            exemption.UserId = dto.UserId;
            exemption.ClassId = dto.ClassId;
            exemption.ExemptionObjects = dto.ExemptionObjects;
            exemption.FormExemption = dto.FormExemption;

            await _context.SaveChangesAsync();
            return exemption;
        }

        public async Task<bool> DeleteAsync(int exemptionId)
        {
            var exemption = await _context.Exemptions.FindAsync(exemptionId);
            if (exemption == null) return false;

            _context.Exemptions.Remove(exemption);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}