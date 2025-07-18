using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Question
    {
        public Question()
        {
            AssessmentQuestions = new HashSet<AssessmentQuestion>();
            QuestionOptions = new HashSet<QuestionOption>();
            StudentMcqanswers = new HashSet<StudentMcqanswer>();
            LabSchedules = new HashSet<LabSchedule>();
        }

        public int QuestionsId { get; set; }
        public string? QuestionsText { get; set; }
        public string? QuestionsType { get; set; }
        public int? UserId { get; set; }
        public int? SubjectId { get; set; }

        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
        public virtual ICollection<StudentMcqanswer> StudentMcqanswers { get; set; }

        public virtual ICollection<LabSchedule> LabSchedules { get; set; }
    }
}
