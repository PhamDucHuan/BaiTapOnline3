using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ClassHistorySession
    {
        public int SessisonHistoryId { get; set; }
        public string? SessisonTotal { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? HistoryId { get; set; }

        public virtual ClassHistory? History { get; set; }
    }
}
