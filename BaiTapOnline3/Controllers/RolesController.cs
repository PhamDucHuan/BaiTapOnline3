using BaiTapOnline3.Interface;
using BaiTapOnline3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapOnline3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            var roles = await _roleService.GetRolesAsync();
            return Ok(roles);
        }

        [HttpPost]
        public async Task<ActionResult<Role>> PostRole(Role role)
        {
            var createdRole = await _roleService.CreateRoleAsync(role);
            return CreatedAtAction(nameof(GetRoles), new { id = createdRole.RoleId }, createdRole);
        }
    }
}