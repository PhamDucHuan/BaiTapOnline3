using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Grade
    {
        public int GradeId { get; set; }
        public string? GradesName { get; set; }
        public string? GradesCode { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UserId { get; set; }
        public int? TrainingId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual TrainingLevel? Training { get; set; }
    }
}
