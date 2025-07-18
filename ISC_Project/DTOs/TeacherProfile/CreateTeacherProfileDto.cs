using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Teacher
{
    // DTO để trả về
    public class TeacherProfileDto
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; } = null!;
        public string TeacherCode { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Status { get; set; } = null!;
    }

    // DTO để tạo mới
    public class CreateTeacherProfileDto
    {
        [Required]
        [StringLength(255)]
        public string TeacherName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string TeacherCode { get; set; } = null!;

        [StringLength(100)]
        public string Position { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [EmailAddress]
        public string Email { get; set; } = null!;

        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public int Department_ID { get; set; }
    }
}