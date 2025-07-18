namespace ISC_Project.DTOs.QuestionBank
{
    public class QuestionDetailDto
    {
        public int QuestionId { get; set; }
        public string? QuestionText { get; set; }
        public string? QuestionType { get; set; }
        public List<QuestionOptionDto> Options { get; set; } = new List<QuestionOptionDto>();
    }

    public class QuestionOptionDto
    {
        public int QuestionOptionId { get; set; }
        public string? OptionText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
