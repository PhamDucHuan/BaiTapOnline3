using BaiTapOnline3.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapOnline3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InternsController : ControllerBase
    {
        private readonly IInternService _internService;

        public InternsController(IInternService internService)
        {
            _internService = internService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInterns()
        {
            var result = await _internService.GetInternsAsync(User); // Truyền User từ Controller
            if (result == null)
            {
                return Forbid("Không thể xác định quyền của người dùng.");
            }
            return Ok(result);
        }
    }
}