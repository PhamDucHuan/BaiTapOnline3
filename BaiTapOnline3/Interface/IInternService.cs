using System.Security.Claims;

namespace BaiTapOnline3.Interface
{
    public interface IInternService
    {
        Task<IEnumerable<IDictionary<string, object>>> GetInternsAsync(ClaimsPrincipal user);
    }
}
