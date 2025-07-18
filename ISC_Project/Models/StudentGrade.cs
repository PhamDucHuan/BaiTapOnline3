using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class StudentGrade
    {
        public int StudentGradesId { get; set; }
        public double? Score { get; set; }
        public string? Comments { get; set; }
        public DateTime? GradedTime { get; set; }
        public int? SubmissionId { get; set; }
        public int? UserId { get; set; }

        public virtual User1? User { get; set; }
    }
}
