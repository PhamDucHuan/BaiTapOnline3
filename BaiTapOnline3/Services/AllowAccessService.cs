using BaiTapOnline3.Data;
using BaiTapOnline3.Interface;
using BaiTapOnline3.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapOnline3.Services
{
    public class AllowAccessService : IAllowAccessService
    {
        private readonly Project_Online3DBContext _context;

        public AllowAccessService(Project_Online3DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AllowAccess>> GetAllowAccessesAsync()
        {
            return await _context.AllowAccesses.Include(a => a.Role).ToListAsync();
        }

        public async Task<AllowAccess> GetAllowAccessAsync(int id)
        {
            return await _context.AllowAccesses.Include(a => a.Role).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<AllowAccess> CreateAllowAccessAsync(AllowAccess allowAccess)
        {
            _context.AllowAccesses.Add(allowAccess);
            await _context.SaveChangesAsync();
            return allowAccess;
        }

        public async Task<bool> UpdateAllowAccessAsync(int id, AllowAccess allowAccess)
        {
            _context.Entry(allowAccess).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.AllowAccesses.Any(e => e.Id == id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }

        public async Task<bool> DeleteAllowAccessAsync(int id)
        {
            var allowAccess = await _context.AllowAccesses.FindAsync(id);
            if (allowAccess == null)
            {
                return false;
            }

            _context.AllowAccesses.Remove(allowAccess);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}