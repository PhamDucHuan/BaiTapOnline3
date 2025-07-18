using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Exemption
    {
        public int ExemptionsId { get; set; }
        public string? ExemptionObjects { get; set; }
        public string? FormExemption { get; set; }
        public int? UserId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual User1? User { get; set; }
    }
}
