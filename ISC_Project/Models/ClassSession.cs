using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ClassSession
    {
        public int SessionId { get; set; }
        public string? Topic { get; set; }
        public string? Description { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public DateTime? StartTimestamp { get; set; }
        public DateTime? EndTimestamp { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? AutoStart { get; set; }
        public bool? EnableRecording { get; set; }
        public bool? AllowSharing { get; set; }
        public string? ShareLink { get; set; }
        public int? UserId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual User1? User { get; set; }
    }
}
