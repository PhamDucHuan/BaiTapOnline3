using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.RewardDiscipline
{
    public class CreateRewardOrDisciplineDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public string Content { get; set; } = null!;
        public DateTime? DecisionDate { get; set; }
    }
}
