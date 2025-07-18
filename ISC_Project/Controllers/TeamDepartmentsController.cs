using ISC_Project.DTOs.Department;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.API.Controllers
{
    [Authorize]
    [Route("api/departments")]
    [ApiController]
    public class TeamDepartmentsController : ControllerBase
    {
        private readonly ITeamDepartmentService _service;
        public TeamDepartmentsController(ITeamDepartmentService service) { _service = service; }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDepartmentDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newItem = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = newItem.DepartmentId }, newItem);
        }
    }
}