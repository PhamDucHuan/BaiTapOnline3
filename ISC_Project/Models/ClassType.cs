using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ClassType
    {
        public ClassType()
        {
            Classes = new HashSet<Class>();
        }

        public int ClassTypeId { get; set; }
        public string? ClassTypeName { get; set; }
        public string? Note { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
