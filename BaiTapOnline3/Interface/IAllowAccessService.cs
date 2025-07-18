using BaiTapOnline3.Models;

namespace BaiTapOnline3.Interface
{
    public interface IAllowAccessService
    {
        Task<IEnumerable<AllowAccess>> GetAllowAccessesAsync();
        Task<AllowAccess> GetAllowAccessAsync(int id);
        Task<AllowAccess> CreateAllowAccessAsync(AllowAccess allowAccess);
        Task<bool> UpdateAllowAccessAsync(int id, AllowAccess allowAccess);
        Task<bool> DeleteAllowAccessAsync(int id);
    }
}
