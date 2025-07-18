using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassDetails = new HashSet<ClassDetail>();
            ClassHistories = new HashSet<ClassHistory>();
            ClassSessions = new HashSet<ClassSession>();
            ClassroomSettings = new HashSet<ClassroomSetting>();
            Disciplines = new HashSet<Discipline>();
            Exemptions = new HashSet<Exemption>();
            TeacherProfiles = new HashSet<TeacherProfile>();
            TeachingAssessments = new HashSet<TeachingAssessment>();
        }

        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public string? ClassCode { get; set; }
        public string? ClassPassword { get; set; }
        public int? StudentNumber { get; set; }
        public string? Classification { get; set; }
        public string? FileClassUrl { get; set; }
        public string? Description { get; set; }
        public int? NumberOfSessions { get; set; }
        public string? Status { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? ClassUrl { get; set; }
        public string? JoinCode { get; set; }
        public string? JoinPassword { get; set; }
        public int? UserId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ClassTypeId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual ClassType? ClassType { get; set; }
        public virtual TeamDepartment? Department { get; set; }
        public virtual User1? User { get; set; }
        public virtual ICollection<ClassDetail> ClassDetails { get; set; }
        public virtual ICollection<ClassHistory> ClassHistories { get; set; }
        public virtual ICollection<ClassSession> ClassSessions { get; set; }
        public virtual ICollection<ClassroomSetting> ClassroomSettings { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<Exemption> Exemptions { get; set; }
        public virtual ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public virtual ICollection<TeachingAssessment> TeachingAssessments { get; set; }
    }
}
