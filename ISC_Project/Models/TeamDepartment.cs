using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class TeamDepartment
    {
        public TeamDepartment()
        {
            ClassDetails = new HashSet<ClassDetail>();
            Classes = new HashSet<Class>();
            Subjects = new HashSet<Subject>();
            TeacherProfiles = new HashSet<TeacherProfile>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? SchoolYearId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolId { get; set; }

        public virtual SchoolProfile? School { get; set; }
        public virtual User1? SchoolYear { get; set; }
        public virtual ICollection<ClassDetail> ClassDetails { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<TeacherProfile> TeacherProfiles { get; set; }
    }
}
