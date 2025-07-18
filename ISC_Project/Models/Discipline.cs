using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Discipline
    {
        public int DisciplineId { get; set; }
        public DateTime? DisciplineDate { get; set; }
        public string? Content { get; set; }
        public string? DisciplineRewardUrl { get; set; }
        public DateTime? DecisionDay { get; set; }
        public string? FileUrl { get; set; }
        public int? UserId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual User1? User { get; set; }
    }
}
