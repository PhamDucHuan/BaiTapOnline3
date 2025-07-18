using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.RewardDiscipline
{
    public class UpdateRewardOrDisciplineDto
    {
        [Required(ErrorMessage = "Nội dung không được để trống")]
        public string Content { get; set; } = null!;

        public DateTime? DecisionDate { get; set; }
    }
}
