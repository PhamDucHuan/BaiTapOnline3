using ISC_Project.DTOs.DiscussionThreads;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/discussionthread")]
    [ApiController]
    public class DiscussionThreadController : ControllerBase
    {
        private readonly IDiscussionThreadService _service;

        public DiscussionThreadController(IDiscussionThreadService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var discussionThread = await _service.GetByIdAsync(id);
            return discussionThread == null ? NotFound() : Ok(discussionThread);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDiscussionThreadDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var discussionThread = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = discussionThread.DiscussionId }, discussionThread);
        }
    }
}
