using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Reserved
    {
        public int ReasonId { get; set; }
        public string? Reason { get; set; }
        public DateTime? DateReserved { get; set; }
        public int? ReservedPeriod { get; set; }
        public string? FileUrl { get; set; }
        public int? UserId { get; set; }
        public int? ClassIdpresent { get; set; }
        public int? ClassIdmoveTo { get; set; }

        public virtual User1? User { get; set; }
    }
}
