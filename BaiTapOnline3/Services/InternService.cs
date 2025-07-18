using BaiTapOnline3.Data;
using BaiTapOnline3.Interface;
using BaiTapOnline3.Models;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using System.Security.Claims;

namespace BaiTapOnline3.Services
{
    public class InternService : IInternService
    {
        private readonly Project_Online3DBContext _context;

        public InternService(Project_Online3DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IDictionary<string, object>>> GetInternsAsync(ClaimsPrincipal user)
        {
            var roleIdClaim = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role);
            if (roleIdClaim == null || !int.TryParse(roleIdClaim.Value, out int roleId))
            {
                // Trả về null hoặc throw exception tùy theo logic bạn muốn
                return null;
            }

            var permission = await _context.AllowAccesses
                .FirstOrDefaultAsync(a => a.RoleId == roleId && a.TableName == "Intern");

            if (permission == null || string.IsNullOrWhiteSpace(permission.AccessProperties))
            {
                return new List<IDictionary<string, object>>();
            }

            var allowedProperties = permission.AccessProperties.Split(',').Select(p => p.Trim()).ToList();
            var interns = await _context.Interns.ToListAsync();
            var resultList = new List<IDictionary<string, object>>();

            foreach (var intern in interns)
            {
                var shapedObject = new ExpandoObject() as IDictionary<string, object>;
                foreach (var propName in allowedProperties)
                {
                    var propInfo = typeof(Intern).GetProperty(propName,
                        System.Reflection.BindingFlags.IgnoreCase |
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.Instance);

                    if (propInfo != null)
                    {
                        shapedObject.Add(propInfo.Name, propInfo.GetValue(intern));
                    }
                }
                resultList.Add(shapedObject);
            }

            return resultList;
        }
    }
}