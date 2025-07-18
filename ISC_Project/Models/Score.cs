using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Score
    {
        public Score()
        {
            LearningOutcomes = new HashSet<LearningOutcome>();
        }

        public int ScoreId { get; set; }
        public string? ScoreType { get; set; }
        public string? Coefficient { get; set; }
        public int? ScoreNumber { get; set; }
        public int? AverageScore { get; set; }
        public string? Semester { get; set; }
        public int? SubjectsId { get; set; }
        public int? ClassId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual Subject? Subjects { get; set; }
        public virtual ICollection<LearningOutcome> LearningOutcomes { get; set; }
    }
}
