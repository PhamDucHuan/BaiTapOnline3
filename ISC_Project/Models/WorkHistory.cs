using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class WorkHistory
    {
        public int WordId { get; set; }
        public string? OrganizationName { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public DateTime? StarTime { get; set; }
        public DateTime? Endtime { get; set; }
        public string? Description { get; set; }
        public string? CertificateName { get; set; }
        public string? TrainingType { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }
        public int? ClassId { get; set; }

        public virtual User1? User { get; set; }
    }
}
