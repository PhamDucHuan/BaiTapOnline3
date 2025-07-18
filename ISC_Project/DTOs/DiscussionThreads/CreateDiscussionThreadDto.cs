
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ISC_Project.DTOs.DiscussionThreads
{
    public class CreateDiscussionThreadDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TeachingId { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Visibility { get; set; }
        [Required]
        public bool IsResolved { get; set; }
        [Required]
        public int ViewCount { get; set; }
        [Required]
        public DateTime CreateAt = DateTime.Now;

    }
}
