using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Department
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }

    public class CreateDepartmentDto
    {
        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; } = null!;

        [Required]
        public int SchoolId { get; set; }
    }
}