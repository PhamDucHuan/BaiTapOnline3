using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class StudentsChangeClass
    {
        public int StudentsChangeClassesId { get; set; }
        public string? Reason { get; set; }
        public string? FileUrl { get; set; }
        public int? ClassIdpresent { get; set; }
        public int? ClassIdmoveTo { get; set; }
        public int? UserId { get; set; }

        public virtual User1? User { get; set; }
    }
}
