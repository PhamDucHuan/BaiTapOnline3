using ISC_Project.DTOs.Exam;
using ISC_Project.Interface.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ISC_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }

        // Endpoint cho giáo viên tạo bài kiểm tra
        [HttpPost]
        [Authorize(Roles = "Teacher")] // Chỉ giáo viên mới được gọi API này
        public async Task<IActionResult> CreateExam([FromBody] ExamCreationDto examDto)
        {
            // Lấy User ID của giáo viên từ token
            var teacherUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            try
            {
                var labScheduleId = await _examService.CreateExamAsync(examDto, teacherUserId);
                return CreatedAtAction(nameof(GetExamById), new { id = labScheduleId }, new { labScheduleId });
            }
            catch (Exception ex)
            {
                // Dòng này sẽ cho bạn biết lỗi gốc rễ từ CSDL là gì.
                // Hãy đặt một breakpoint ở đây và xem giá trị của ex.InnerException.Message
                var errorMessage = ex.InnerException?.Message ?? ex.Message;
                return BadRequest(errorMessage);
            }
        }

        // Endpoint cho học sinh bắt đầu làm bài
        [HttpPost("{id}/start")]
        [Authorize(Roles = "Student")] // Chỉ học sinh
        public async Task<ActionResult<StartedExamDto>> StartExam(int id)
        {
            var studentUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var startedExam = await _examService.StartExamAsync(id, studentUserId);
            return Ok(startedExam);
        }

        // Endpoint cho học sinh nộp 1 câu trả lời
        [HttpPost("submit-answer")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> SubmitAnswer([FromBody] SubmitAnswerDto answerDto)
        {
            // Cần thêm logic xác thực xem người dùng có quyền nộp bài cho submission này không
            await _examService.SubmitAnswerAsync(answerDto);
            return Ok();
        }

        // Endpoint để kết thúc và chấm điểm
        [HttpPost("submission/{submissionId}/finalize")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> FinalizeExam(int submissionId)
        {
            var score = await _examService.FinalizeAndGradeExamAsync(submissionId);
            return Ok(new { submissionId, finalScore = score });
        }

        // Endpoint ví dụ để lấy thông tin bài thi (chưa implement)
        [HttpGet("{id}")]
        public IActionResult GetExamById(int id)
        {
            // TODO: Implement logic to get exam details
            return Ok(new { Message = $"Details for exam {id}" });
        }
    }
}
