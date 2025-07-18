using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class LiveSession
    {
        public LiveSession()
        {
            LiveChatMessages = new HashSet<LiveChatMessage>();
        }

        public int LiveSessionsId { get; set; }
        public DateTime? ScheduledStartTime { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public string? Status { get; set; }
        public string? RecordingUrl { get; set; }
        public int? TeachingId { get; set; }

        public virtual TeachingAssessment? Teaching { get; set; }
        public virtual ICollection<LiveChatMessage> LiveChatMessages { get; set; }
    }
}
