using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.LiveChatMessage
{

    public class CreateLiveChatMessageDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int LiveSessionId { get; set; }
        [Required]
        public string MessageContent { get; set; }
        [Required]
        public bool IsPinned { get; set; }

        public string? recording_url { get; set; }

        public DateTime SentAt { get; set; }


        [Required]
        [RegularExpression("^(Cả lớp|Giáo viên|QnA)$", ErrorMessage = "Loại tin nhắn không hợp lệ.")]
        public string MessageType { get; set; } = null!;

        [Required]
        [RegularExpression("^(Active|Delete|Edited)$", ErrorMessage = "Trạng thái không hợp lệ.")]
        public string Status { get; set; } = null!;
    }
}

