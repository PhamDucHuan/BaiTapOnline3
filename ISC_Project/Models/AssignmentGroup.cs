using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class AssignmentGroup
    {
        public int? AssignmentsId { get; set; }
        public int? ClassId { get; set; }

        public virtual Assignment? Assignments { get; set; }
        public virtual Class? Class { get; set; }
    }
}
