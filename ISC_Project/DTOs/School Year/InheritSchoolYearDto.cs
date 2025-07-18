using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.School_Year
{
    public class InheritSchoolYearDto
    {
        [Required(ErrorMessage = "Tên niên khóa mới không được để trống.")]
        [StringLength(100)]
        public string NewSchoolYearName { get; set; } = null!;

        [Required]
        public DateTime NewStartTime { get; set; }

        [Required]
        public DateTime NewEndTime { get; set; }

        [Required(ErrorMessage = "Cần chọn một niên khóa cũ để kế thừa.")]
        public int SourceSchoolYearId { get; set; } // ID của niên khóa cũ
    }
}
