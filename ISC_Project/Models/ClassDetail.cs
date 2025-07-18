using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ClassDetail
    {
        public int DetailClassId { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string? Status { get; set; }
        public int? NumberOfSubjects { get; set; }
        public string? Description { get; set; }
        public int? StudentId { get; set; }
        public int? ClassId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual TeamDepartment? Department { get; set; }
        public virtual User1? User { get; set; }
    }
}
