using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.LiveSession
{
    public class CreateLiveSessionDto
    {
        [Required]
        public int TeachingId { get; set; }
        [Required]
        public DateTime? ScheduledStartTime { get; set; }
        [Required]
        public DateTime? ActualStartTime { get; set; }
        [Required]
        public DateTime? ActualEndTime { get; set; }
        [Required]
        public string? Status { get; set; }
        public string? RecordingUrl { get; set; }
    }
}
