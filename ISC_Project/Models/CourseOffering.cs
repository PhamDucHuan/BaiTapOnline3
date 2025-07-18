using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class CourseOffering
    {
        public CourseOffering()
        {
            CourseLessons = new HashSet<CourseLesson>();
            Registrations = new HashSet<Registration>();
        }

        public int CourseOfferingsId { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? MaxStudent { get; set; }
        public decimal? Price { get; set; }
        public string? Status { get; set; }
        public int? CoursesId { get; set; }
        public int? InstructorUserId { get; set; }

        public virtual Course? Courses { get; set; }
        public virtual User1? InstructorUser { get; set; }
        public virtual ICollection<CourseLesson> CourseLessons { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
