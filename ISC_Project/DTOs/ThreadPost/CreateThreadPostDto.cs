using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ISC_Project.DTOs.ThreadPost
{
    public class CreateThreadPostDto
    {
        [Required]
        public string? Content { get; set; }
        [Required]
        public DateOnly? CreatedAt { get; set; }
        public string? AttachmentUrl { get; set; }
        [Required]
        public int? DiscussionId { get; set; }
        [Required]
        public int? UserId { get; set; }
    }
}
