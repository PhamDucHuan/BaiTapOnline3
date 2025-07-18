using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class SubjectsClass
    {
        public int? SubjectsId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subjects { get; set; }
    }
}
