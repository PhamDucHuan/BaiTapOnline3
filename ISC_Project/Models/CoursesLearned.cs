using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class CoursesLearned
    {
        public int CoursesLearnedId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Syllabus { get; set; }
        public decimal? DefaultPrice { get; set; }
        public string? CoursesImageUrl { get; set; }
        public int? TotalCoursesId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual TotalCoursesTaken? TotalCourses { get; set; }
    }
}
