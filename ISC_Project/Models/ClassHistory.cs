using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ClassHistory
    {
        public ClassHistory()
        {
            ClassHistorySessions = new HashSet<ClassHistorySession>();
        }

        public int HistoryId { get; set; }
        public string? Decription { get; set; }
        public int? TotalSessisons { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? UserId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual ICollection<ClassHistorySession> ClassHistorySessions { get; set; }
    }
}
