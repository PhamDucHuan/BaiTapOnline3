using BaiTapOnline3.Interface;
using BaiTapOnline3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapOnline3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AllowAccessController : ControllerBase
    {
        private readonly IAllowAccessService _allowAccessService;

        public AllowAccessController(IAllowAccessService allowAccessService)
        {
            _allowAccessService = allowAccessService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllowAccess>>> GetAllowAccesses()
        {
            var result = await _allowAccessService.GetAllowAccessesAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AllowAccess>> GetAllowAccess(int id)
        {
            var allowAccess = await _allowAccessService.GetAllowAccessAsync(id);
            if (allowAccess == null)
            {
                return NotFound();
            }
            return Ok(allowAccess);
        }

        [HttpPost]
        public async Task<ActionResult<AllowAccess>> PostAllowAccess(AllowAccess allowAccess)
        {
            var created = await _allowAccessService.CreateAllowAccessAsync(allowAccess);
            return CreatedAtAction(nameof(GetAllowAccess), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAllowAccess(int id, AllowAccess allowAccess)
        {
            if (id != allowAccess.Id)
            {
                return BadRequest();
            }

            var success = await _allowAccessService.UpdateAllowAccessAsync(id, allowAccess);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAllowAccess(int id)
        {
            var success = await _allowAccessService.DeleteAllowAccessAsync(id);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}