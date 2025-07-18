using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            AssessmentParts = new HashSet<AssessmentPart>();
        }

        public int AssignmentId { get; set; }
        public string? Title { get; set; }
        public string? Format { get; set; }
        public string? AssignmentScope { get; set; }
        public string? Category { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? AssignmentUrl { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? PartitionType { get; set; }
        public DateTime? CraeteAt { get; set; }
        public int? TeachingId { get; set; }
        public int? FacultyId { get; set; }

        public virtual TeachingAssessment? Teaching { get; set; }
        public virtual ICollection<AssessmentPart> AssessmentParts { get; set; }
    }
}
