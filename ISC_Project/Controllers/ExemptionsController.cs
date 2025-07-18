using ISC_Project.DTOs.Exemption;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/exemptions")]
    public class ExemptionsController : ControllerBase
    {
        private readonly IExemptionService _service;

        public ExemptionsController(IExemptionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var exemption = await _service.GetByIdAsync(id);
            return exemption == null ? NotFound() : Ok(exemption);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateExemptionDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var exemption = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = exemption.ExemptionsId }, exemption);
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, [FromBody] CreateExemptionDto dto)
        //{
        //    if (!ModelState.IsValid) return BadRequest(ModelState);
        //    var updatedExemption = await _service.UpdateAsync(id, dto);
        //    return updatedExemption == null ? NotFound() : Ok(updatedExemption);
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var success = await _service.DeleteAsync(id);
        //    return success ? NoContent() : NotFound();
        //}
    }
}