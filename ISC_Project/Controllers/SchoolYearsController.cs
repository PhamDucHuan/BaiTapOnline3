using ISC_Project.DTOs.School_Year;
using ISC_Project.DTOs.SchoolYear;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.API.Controllers
{
    [Authorize]
    [Route("api/school-years")]
    [ApiController]
    public class SchoolYearsController : ControllerBase
    {
        private readonly ISchoolYearService _service;
        public SchoolYearsController(ISchoolYearService service) { _service = service; }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSchoolYearDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newItem = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = newItem.SchoolYearId }, newItem);
        }

        [HttpPost("inherit")]
        [Authorize(Roles = "Admin")] // Chỉ Admin mới được thực hiện hành động này
        public async Task<IActionResult> InheritSchoolYear([FromBody] InheritSchoolYearDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var newSchoolYear = await _service.InheritAsync(dto);
                return Ok(new
                {
                    message = "Kế thừa niên khóa thành công.",
                    data = newSchoolYear
                });
            }
            catch (Exception ex)
            {
                // Trả về lỗi server nếu có vấn đề xảy ra trong quá trình kế thừa
                return StatusCode(500, $"Đã xảy ra lỗi trong quá trình kế thừa: {ex.Message}");
            }
        }
    }
}