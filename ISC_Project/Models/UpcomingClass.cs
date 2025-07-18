using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class UpcomingClass
    {
        public int ClassId { get; set; }
        public DateTime? StartTime { get; set; }
        public string? Status { get; set; }
        public int? SubjectId { get; set; }
        public int? UserId { get; set; }

        public virtual Subject? Subject { get; set; }
        public virtual User1? User { get; set; }
    }
}
