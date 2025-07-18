using ISC_Project.DTOs.Teacher;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.API.Controllers
{
    [Authorize(Roles = "Admin,Teacher")]
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherProfilesController : ControllerBase
    {
        private readonly ITeacherProfileService _service;
        public TeacherProfilesController(ITeacherProfileService service) { _service = service; }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTeacherProfileDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newItem = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = newItem.TeacherId }, newItem);
        }
    }
}