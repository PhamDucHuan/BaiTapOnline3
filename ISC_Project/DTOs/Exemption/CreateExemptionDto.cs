using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.Exemption
{
    public class CreateExemptionDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ClassId { get; set; }

        [Required]
        [RegularExpression("^(Toàn trường|Giáo viên|Học sinh|Từng lớp)$", ErrorMessage = "ExemptionObjects không hợp lệ.")]
        public string ExemptionObjects { get; set; } = null!;

        [Required]
        [RegularExpression("^(Miễn 100%|Giảm 50%|Miễn học phí)$", ErrorMessage = "FormExemption không hợp lệ.")]
        public string FormExemption { get; set; } = null!;
    }
}
