using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class FacultyStudyBlock
    {
        public int FacultyId { get; set; }
        public string? FacultyName { get; set; }
        public string? FacultyCode { get; set; }
        public int? UserId { get; set; }
        public int? SchoolId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual SchoolProfile? School { get; set; }
        public virtual SchoolYear? SchoolYear { get; set; }
        public virtual User1? User { get; set; }
    }
}
