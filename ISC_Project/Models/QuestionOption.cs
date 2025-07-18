using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class QuestionOption
    {
        public QuestionOption()
        {
            StudentMcqanswers = new HashSet<StudentMcqanswer>();
        }

        public int QuestionOptionsId { get; set; }
        public int? QuestionsId { get; set; }
        public string? OptionText { get; set; }
        public bool? IsCorrect { get; set; }

        public virtual Question? Questions { get; set; }
        public virtual ICollection<StudentMcqanswer> StudentMcqanswers { get; set; }
    }
}
