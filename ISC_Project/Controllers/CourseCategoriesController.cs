using ISC_Project.DTOs.Course;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.API.Controllers
{
    [Authorize]
    [Route("api/course-categories")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private readonly ICourseCategoryService _service;
        public CourseCategoriesController(ICourseCategoryService service) { _service = service; }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseCategoryDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newItem = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = newItem.CourseCategoriesId }, newItem);
        }
    }
}