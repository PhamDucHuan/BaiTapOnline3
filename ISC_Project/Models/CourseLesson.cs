using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class CourseLesson
    {
        public int CourseLessonsId { get; set; }
        public string? Title { get; set; }
        public DateTime? LessonTime { get; set; }
        public string? RoomNumber { get; set; }
        public string? Status { get; set; }
        public int? CourseOfferingsId { get; set; }
        public int? SchoolId { get; set; }

        public virtual CourseOffering? CourseOfferings { get; set; }
        public virtual SchoolProfile? School { get; set; }
    }
}
