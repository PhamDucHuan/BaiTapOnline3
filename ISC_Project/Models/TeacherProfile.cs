using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class TeacherProfile
    {
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public string? TeacherCode { get; set; }
        public string? Position { get; set; }
        public bool? Member { get; set; }
        public bool? PartyMember { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Nation { get; set; }
        public string? Status { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? Religion { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string? Form { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int? NumberRewards { get; set; }
        public int? NumberDisciplinaryActions { get; set; }
        public string? FileUrl { get; set; }
        public int? SubjectId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual TeamDepartment? Department { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual User1? User { get; set; }
    }
}
