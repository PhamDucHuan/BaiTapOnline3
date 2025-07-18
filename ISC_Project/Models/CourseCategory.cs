using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class CourseCategory
    {
        public CourseCategory()
        {
            Courses = new HashSet<Course>();
        }

        public int CourseCategoriesId { get; set; }
        public string? CourseCategoriesName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
