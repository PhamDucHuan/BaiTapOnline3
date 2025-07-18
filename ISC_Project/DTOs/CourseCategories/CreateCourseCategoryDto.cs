using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Course
{
    public class CourseCategoryDto
    {
        public int CourseCategoriesId { get; set; }
        public string CourseCategoriesName { get; set; } = null!;
    }

    public class CreateCourseCategoryDto
    {
        [Required]
        [StringLength(255)]
        public string CourseCategoriesName { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}