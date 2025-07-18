using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Semester
    {
        public int SemesterId { get; set; }
        public string? SemesterName { get; set; }
        public int? LessonOfSemester { get; set; }
        public DateTime? StarTimeSemester { get; set; }
        public DateTime? EndTimeSemester { get; set; }
        public bool? IsCurrent { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual SchoolYear? SchoolYear { get; set; }
    }
}
