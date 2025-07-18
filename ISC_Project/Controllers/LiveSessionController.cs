using ISC_Project.DTOs.LiveSession;
using ISC_Project.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LiveSessionController : ControllerBase
    {
        private readonly ILiveSessionService _service;

        public LiveSessionController(ILiveSessionService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var liveSession = await _service.GetByIdAsync(id);
            return liveSession == null ? NotFound() : Ok(liveSession);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLiveSessionDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var liveSession = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = liveSession.LiveSessionsId }, liveSession);
        }
    }
}
