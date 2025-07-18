using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class AssessmentQuestion
    {
        public int AssessmentQuestionsId { get; set; }
        public int? QuestionOrder { get; set; }
        public int? QuestionsId { get; set; }

        public virtual Question? Questions { get; set; }
    }
}
