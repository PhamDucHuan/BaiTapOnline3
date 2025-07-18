using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClassHistoryController : ControllerBase
    {
        private readonly IClassHistoryService _service;

        public ClassHistoryController(IClassHistoryService service)
        {
            _service = service;
        }

        [HttpPost("create-history")]
        public async Task<IActionResult> CreateClassHistory([FromBody] ClassHistory history)
        {
            if (history == null) return BadRequest("Invalid data");
            var result = await _service.CreateHistoryAsync(history);
            return Ok(result);
        }

        [HttpPost("add-session")]
        public async Task<IActionResult> AddClassHistorySession([FromBody] ClassHistorySession session)
        {
            if (session == null) return BadRequest("Invalid data");
            var result = await _service.AddSessionAsync(session);
            return Ok(result);
        }

        [HttpGet("history-by-class/{classId}")]
        public async Task<IActionResult> GetClassHistoryByClass(int classId)
        {
            var result = await _service.GetHistoryByClassAsync(classId);
            return Ok(result);
        }

        [HttpGet("sessions-by-history/{historyId}")]
        public async Task<IActionResult> GetSessionsByHistory(int historyId)
        {
            var result = await _service.GetSessionsByHistoryAsync(historyId);
            return Ok(result);
        }
    }
}
