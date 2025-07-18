using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Subject
{
    public class SubjectDto
    {
        public int SubjectsId { get; set; }
        public string SubjectsName { get; set; } = null!;
        public string SubjectCode { get; set; } = null!;
    }

    public class CreateSubjectDto
    {
        [Required]
        [StringLength(255)]
        public string SubjectsName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string SubjectCode { get; set; } = null!;

        [Required]
        public int DepartmentId { get; set; }
    }
}