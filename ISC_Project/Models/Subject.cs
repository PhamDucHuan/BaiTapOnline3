using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Subject
    {
        public Subject()
        {
            LabSchedules = new HashSet<LabSchedule>();
            PastClasses = new HashSet<PastClass>();
            Scores = new HashSet<Score>();
            TeacherProfiles = new HashSet<TeacherProfile>();
            TeachingAssessments = new HashSet<TeachingAssessment>();
            UpcomingClasses = new HashSet<UpcomingClass>();
        }

        public int SubjectsId { get; set; }
        public string? SubjectCode { get; set; }
        public string? SubjectsName { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? SubjectTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual TeamDepartment? Department { get; set; }
        public virtual User1? User { get; set; }
        public virtual ICollection<LabSchedule> LabSchedules { get; set; }
        public virtual ICollection<PastClass> PastClasses { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
        public virtual ICollection<TeacherProfile> TeacherProfiles { get; set; }
        public virtual ICollection<TeachingAssessment> TeachingAssessments { get; set; }
        public virtual ICollection<UpcomingClass> UpcomingClasses { get; set; }
    }
}
