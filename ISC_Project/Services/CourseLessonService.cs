using ISC_Project.Data;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ISC_Project.Services
{
    public class CourseLessonService : ICourseLessonService
    {
        private readonly ISC_ProjectDbContext _context;

        public CourseLessonService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CourseLesson>> GetLessonsAsync()
        {
            return await _context.CourseLessons
                                 .Include(cl => cl.CourseOfferings)
                                 .ToListAsync();
        }

        public async Task<CourseLesson> CreateLessonAsync(CourseLesson lesson)
        {
            _context.CourseLessons.Add(lesson);
            await _context.SaveChangesAsync();
            return lesson;
        }
    }
}
