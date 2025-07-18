using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Enrollment
    {
        public int EnrollmentsId { get; set; }
        public string? Status { get; set; }
        public int? SchoolYearId { get; set; }
        public int? ClassId { get; set; }
        public int? UserId { get; set; }
    }
}
