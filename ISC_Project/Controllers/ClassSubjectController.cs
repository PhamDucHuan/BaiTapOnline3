using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClassSubjectController : ControllerBase
    {
        private readonly IClassSubjectService _service;

        public ClassSubjectController(IClassSubjectService service)
        {
            _service = service;
        }

        [HttpGet("classes")]
        public async Task<IActionResult> GetAllClasses()
        {
            var result = await _service.GetAllClassesAsync();
            return Ok(result);
        }

        [HttpGet("subjects")]
        public async Task<IActionResult> GetAllSubjects()
        {
            var result = await _service.GetAllSubjectsAsync();
            return Ok(result);
        }

        [HttpGet("subjects/class/{classId}")]
        public async Task<IActionResult> GetSubjectsByClass(int classId)
        {
            var result = await _service.GetSubjectsByClassIdAsync(classId);
            return Ok(result);
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AssignSubjectToClass([FromBody] SubjectsClass dto)
        {
            await _service.AssignSubjectToClassAsync(dto.SubjectsId, dto.ClassId);
            return Ok("Subject assigned to class successfully.");
        }
    }
}
