using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class TrainingLevel
    {
        public TrainingLevel()
        {
            Grades = new HashSet<Grade>();
        }

        public int TrainingId { get; set; }
        public string? TrainingName { get; set; }
        public string? TrainingForm { get; set; }
        public bool? IsCreditBased { get; set; }
        public DateTime? IsCreditYearBased { get; set; }
        public int? DurationYears { get; set; }
        public int? RequiredCredits { get; set; }
        public int? ElectiveCredits { get; set; }
        public string? Note { get; set; }
        public bool? IsActive { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
