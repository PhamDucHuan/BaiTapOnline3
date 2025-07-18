using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class TotalCoursesTaken
    {
        public TotalCoursesTaken()
        {
            CoursesLearneds = new HashSet<CoursesLearned>();
        }

        public int TotalCoursesId { get; set; }
        public int? TotalNumberCourses { get; set; }
        public decimal? TotalPayment { get; set; }
        public int? CoursesLearnedId { get; set; }
        public int? UserId { get; set; }

        public virtual User1? User { get; set; }
        public virtual ICollection<CoursesLearned> CoursesLearneds { get; set; }
    }
}
