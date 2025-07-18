namespace ISC_Project.DTOs.Exam
{
    public class QuestionForStudentDto
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<OptionDto> Options { get; set; }
    }
    public class OptionDto
    {
        public int OptionId { get; set; }
        public string OptionText { get; set; } = string.Empty;
    }
}
