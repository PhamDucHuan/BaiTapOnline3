using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseOfferings = new HashSet<CourseOffering>();
        }

        public int CoursesId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Syllabus { get; set; }
        public decimal? DefaultPrice { get; set; }
        public string? CoursesImageUrl { get; set; }
        public int? CourseCategoriesId { get; set; }

        public virtual CourseCategory? CourseCategories { get; set; }
        public virtual ICollection<CourseOffering> CourseOfferings { get; set; }
    }
}
