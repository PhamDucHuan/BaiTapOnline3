using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class StudentsChangeSchool
    {
        public int StudentsChangeSchoolId { get; set; }
        public string? Reason { get; set; }
        public string? NameSchoolTransferred { get; set; }
        public string? AddressSchoolTransferred { get; set; }
        public string? FileUrl { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }
    }
}
