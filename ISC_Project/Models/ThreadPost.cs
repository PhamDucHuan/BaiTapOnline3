using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ThreadPost
    {
        public int ThreadPostsId { get; set; }
        public string? Content { get; set; }
        public DateOnly? CreatedAt { get; set; }
        public string? AttachmentUrl { get; set; }
        public int? DiscussionId { get; set; }
        public int? UserId { get; set; }

        public virtual DiscussionThread? Discussion { get; set; }
        public virtual User1? User { get; set; }
    }
}
