using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class TeachingAssessment
    {
        public TeachingAssessment()
        {
            Assignments = new HashSet<Assignment>();
            DiscussionThreads = new HashSet<DiscussionThread>();
            LiveSessions = new HashSet<LiveSession>();
        }

        public int TeachingId { get; set; }
        public string? AssignmentType { get; set; }
        public int? Semester { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Description { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual User1? User { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<DiscussionThread> DiscussionThreads { get; set; }
        public virtual ICollection<LiveSession> LiveSessions { get; set; }
    }
}
