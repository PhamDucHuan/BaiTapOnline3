using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class DiscussionThread
    {
        public DiscussionThread()
        {
            ThreadPosts = new HashSet<ThreadPost>();
        }

        public int DiscussionId { get; set; }
        public string? Title { get; set; }
        public string? Visibility { get; set; }
        public bool? IsResolved { get; set; }
        public int? ViewCount { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UserId { get; set; }
        public int? TeachingId { get; set; }

        public virtual TeachingAssessment? Teaching { get; set; }
        public virtual User1? User { get; set; }
        public virtual ICollection<ThreadPost> ThreadPosts { get; set; }
    }
}
