using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class StudentMcqanswer
    {
        public int StudentMcqanswersId { get; set; }
        public int? SubmissionsId { get; set; }
        public int? QuestionsId { get; set; }
        public int? QuestionOptionsId { get; set; }

        public virtual QuestionOption? QuestionOptions { get; set; }
        public virtual Question? Questions { get; set; }
        public virtual StudentSubmission? Submissions { get; set; }
    }
}
