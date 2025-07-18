using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class SchoolProfile
    {
        public SchoolProfile()
        {
            Campuses = new HashSet<Campus>();
            CourseLessons = new HashSet<CourseLesson>();
            FacultyStudyBlocks = new HashSet<FacultyStudyBlock>();
            SchoolYears = new HashSet<SchoolYear>();
            TeamDepartments = new HashSet<TeamDepartment>();
        }

        public int SchoolId { get; set; }
        public string? SchoolName { get; set; }
        public string? SchoolCode { get; set; }
        public string? ProvinceCity { get; set; }
        public string? CommuneWard { get; set; }
        public string? District { get; set; }
        public string? HeadOffice { get; set; }
        public string? SchoolType { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneFax { get; set; }
        public string? Email { get; set; }
        public string? DateEstablishment { get; set; }
        public string? TrainingModel { get; set; }
        public string? Webside { get; set; }
        public string? PrincipalName { get; set; }
        public string? PhonePrincipal { get; set; }
        public string? FileUrl { get; set; }

        public virtual ICollection<Campus> Campuses { get; set; }
        public virtual ICollection<CourseLesson> CourseLessons { get; set; }
        public virtual ICollection<FacultyStudyBlock> FacultyStudyBlocks { get; set; }
        public virtual ICollection<SchoolYear> SchoolYears { get; set; }
        public virtual ICollection<TeamDepartment> TeamDepartments { get; set; }
    }
}
