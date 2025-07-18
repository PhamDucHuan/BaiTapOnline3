using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Course
{
    public class CourseOfferingDto
    {
        public int CourseOfferingsId { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } = null!;
    }

    public class CreateCourseOfferingDto
    {
        [Required]
        public DateTime StarTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public int MaxStudent { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string Status { get; set; } = null!;
        [Required]
        public int CoursesId { get; set; }
        [Required]
        public int InstructorUserId { get; set; }
    }
}