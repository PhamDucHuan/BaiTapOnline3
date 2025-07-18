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
    public class CourseLessonsController : ControllerBase
    {
        private readonly ICourseLessonService _lessonService;

        public CourseLessonsController(ICourseLessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseLesson>>> GetLessons()
        {
            var lessons = await _lessonService.GetLessonsAsync();
            return Ok(lessons);
        }

        [HttpPost]
        public async Task<ActionResult<CourseLesson>> CreateLesson(CourseLesson lesson)
        {
            var createdLesson = await _lessonService.CreateLessonAsync(lesson);
            return CreatedAtAction(nameof(GetLessons), new { id = createdLesson.CourseLessonsId }, createdLesson);
        }
    }
}
