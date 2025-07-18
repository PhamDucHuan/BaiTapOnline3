using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Qualification
    {
        public int QualificationsId { get; set; }
        public string? Institution { get; set; }
        public string? Major { get; set; }
        public string? StudyForm { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? Endtime { get; set; }
        public string? DegreeName { get; set; }
        public string? AttachmentUrl { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual User1? User { get; set; }
    }
}
