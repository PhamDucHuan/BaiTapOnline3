using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class AssessmentPart
    {
        public AssessmentPart()
        {
            StudentSubmissions = new HashSet<StudentSubmission>();
        }

        public int AssessmentPartsId { get; set; }
        public int? PartOrder { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? AssignmentUrl { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? AssignmentId { get; set; }

        public virtual Assignment? Assignment { get; set; }
        public virtual ICollection<StudentSubmission> StudentSubmissions { get; set; }
    }
}
