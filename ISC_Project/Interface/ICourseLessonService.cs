using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface ICourseLessonService
    {
        Task<IEnumerable<CourseLesson>> GetLessonsAsync();
        Task<CourseLesson> CreateLessonAsync(CourseLesson lesson);
    }
}
