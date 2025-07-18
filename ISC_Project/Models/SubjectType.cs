using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class SubjectType
    {
        public int SubjectTypeId { get; set; }
        public string? SubjectTypeName { get; set; }
        public string? Description { get; set; }
        public bool? Status { get; set; }
        public string? Note { get; set; }
    }
}
