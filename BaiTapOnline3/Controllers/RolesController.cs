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

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole(int id, Role role)
        {
            var updatedRole = await _roleService.UpdateRoleAsync(id, role);
            if (updatedRole == null)
                return NotFound(new { message = "Role not found" });

            return Ok(updatedRole);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var deleted = await _roleService.DeleteRoleAsync(id);
            if (!deleted)
                return NotFound(new { message = "Role not found" });

            return NoContent(); // Xóa thành công
        }

    }
}