using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Student
{
    public class StudentProfileDto
    {
        public int StudentsProfileId { get; set; }
        public string StudentName { get; set; } = null!;
        public string StudentCode { get; set; } = null!;
        public string Status { get; set; } = null!;
    }

    public class CreateStudentProfileDto
    {
        [Required]
        [StringLength(255)]
        public string StudentName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string StudentCode { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Status { get; set; } = null!;

        [Required]
        public int ClassId { get; set; }
    }
}