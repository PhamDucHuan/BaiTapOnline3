namespace ISC_Project.DTOs.Exam
{
    public class StartedExamDto
    {
        public int SubmissionId { get; set; }
        public List<QuestionForStudentDto> ShuffledQuestions { get; set; }
    }
}
