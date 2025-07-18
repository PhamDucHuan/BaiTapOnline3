using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class SchoolYear
    {
        public SchoolYear()
        {
            FacultyStudyBlocks = new HashSet<FacultyStudyBlock>();
            Semesters = new HashSet<Semester>();
        }

        public int SchoolYearId { get; set; }
        public string? SchoolYearName { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? UserId { get; set; }
        public int? SchoolId { get; set; }

        public virtual SchoolProfile? School { get; set; }
        public virtual ICollection<FacultyStudyBlock> FacultyStudyBlocks { get; set; }
        public virtual ICollection<Semester> Semesters { get; set; }
    }
}
