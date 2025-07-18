using ISC_Project.DTOs.ThreadPost;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/ThreadPost")]
    [ApiController]
    public class ThreadPostController : ControllerBase
    {
        private readonly IThreadPostService _service;

        public ThreadPostController(IThreadPostService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var threadPost = await _service.GetByIdAsync(id);
            return threadPost == null ? NotFound() : Ok(threadPost);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateThreadPostDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var threadPost = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = threadPost.ThreadPostsId }, threadPost);
        }
    }
}
