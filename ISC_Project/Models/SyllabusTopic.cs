using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class SyllabusTopic
    {
        public int SyllabusId { get; set; }
        public int? TeachingId { get; set; }
        public string? TopicTitle { get; set; }
        public int? OrderIndex { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Description { get; set; }
        public int? SchoolYearId { get; set; }
    }
}
