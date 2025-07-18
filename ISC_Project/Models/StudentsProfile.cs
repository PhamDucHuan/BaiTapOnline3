using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class StudentsProfile
    {
        public int StudentsProfileId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentCode { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Sex { get; set; }
        public string? Nation { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Religion { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string? Form { get; set; }
        public string? Status { get; set; }
        public int? NumberRewards { get; set; }
        public int? NumberDisciplinaryActions { get; set; }
        public string? FileUrl { get; set; }
        public int? ClassId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }
    }
}
