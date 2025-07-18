
using ISC_Project.DTOs.LiveChatMessage;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/livechat")]
    [ApiController]
    public class LiveChatMessageController : ControllerBase
    {
        private readonly ILiveChatMessageService _service;

        public LiveChatMessageController(ILiveChatMessageService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var liveChatMessage  = await _service.GetByIdAsync(id);
            return liveChatMessage == null ? NotFound() : Ok(liveChatMessage);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLiveChatMessageDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var liveChatMessage = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = liveChatMessage.LiveChatMessagesId }, liveChatMessage);
        }
    }
}
