using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class LearningOutcome
    {
        public int LearningOutcomes { get; set; }
        public string? Conduct { get; set; }
        public int? AverageScore { get; set; }
        public bool? AcademicPerformance { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? ScoreId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual Score? Score { get; set; }
        public virtual User1? User { get; set; }
    }
}
