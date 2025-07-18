using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class StudentSubmission
    {
        public StudentSubmission()
        {
            StudentMcqanswers = new HashSet<StudentMcqanswer>();
        }

        public int SubmissionsId { get; set; }
        public DateTime? SubmissionTime { get; set; }
        public string? FileUrl { get; set; }
        public string? Notes { get; set; }
        public string? TextAnswer { get; set; }
        public int? AssessmentPartsId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }
        public int? LabSchedulesId { get; set; }

        public virtual AssessmentPart? AssessmentParts { get; set; }
        public virtual LabSchedule? LabSchedules { get; set; }
        public virtual User1? User { get; set; }
        public virtual ICollection<StudentMcqanswer> StudentMcqanswers { get; set; }
    }
}
