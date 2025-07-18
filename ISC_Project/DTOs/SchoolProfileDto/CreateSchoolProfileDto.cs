using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.School
{
    public class SchoolProfileDto
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; } = null!;
        public string SchoolCode { get; set; } = null!;
        public string Email { get; set; } = null!;
    }

    public class CreateSchoolProfileDto
    {
        [Required]
        [StringLength(255)]
        public string SchoolName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string SchoolCode { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;

        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}