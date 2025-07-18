using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class LiveChatMessage
    {
        public int LiveChatMessagesId { get; set; }
        public string? MessageType { get; set; }
        public string? MessageContent { get; set; }
        public DateTime? SentAt { get; set; }
        public string? RecordingUrl { get; set; }
        public string? Status { get; set; }
        public bool? IsPinned { get; set; }
        public int? LiveSessionsId { get; set; }
        public int? UserId { get; set; }

        public virtual LiveSession? LiveSessions { get; set; }
    }
}
