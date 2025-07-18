namespace ISC_Project.DTOs.Exam
{
    public class ExamCreationDto
    {
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> QuestionIds { get; set; }
        public List<int> ClassIds { get; set; }
    }
}
