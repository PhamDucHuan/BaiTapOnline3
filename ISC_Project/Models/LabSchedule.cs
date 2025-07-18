using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class LabSchedule
    {
        public LabSchedule()
        {
            StudentSubmissions = new HashSet<StudentSubmission>();
            Questions = new HashSet<Question>();
        }

        public int LabSchedulesId { get; set; }
        public string? TermNumber { get; set; }
        public string? LabName { get; set; }
        public DateTime? LabStartDate { get; set; }
        public DateTime? LabEndDate { get; set; }
        public int? DurationMinutes { get; set; }
        public string? Status { get; set; }
        public int? SubjectId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual Subject? Subject { get; set; }
        public virtual User1? User { get; set; }
        public virtual ICollection<StudentSubmission> StudentSubmissions { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
