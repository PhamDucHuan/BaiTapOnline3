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
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;

        public NotificationController(INotificationService service)
        {
            _service = service;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateNotification([FromBody] Notification noti)
        {
            if (noti == null) return BadRequest("Invalid data");
            var result = await _service.CreateNotificationAsync(noti);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllNotifications()
        {
            var result = await _service.GetAllNotificationsAsync();
            return Ok(result);
        }

        [HttpGet("by-object/{objectName}")]
        public async Task<IActionResult> GetByReceivingObject(string objectName)
        {
            var result = await _service.GetByReceivingObjectAsync(objectName);
            return Ok(result);
        }
    }
}
