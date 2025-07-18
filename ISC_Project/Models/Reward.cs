using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Reward
    {
        public int RewardId { get; set; }
        public DateTime? RewardDate { get; set; }
        public string? Content { get; set; }
        public string? Field { get; set; }
        public string? DecisionRewardUrl { get; set; }
        public string? DecisionDay { get; set; }
        public string? FileUrl { get; set; }
        public int? UserId { get; set; }
        public int? ClassId { get; set; }

        public virtual User1? User { get; set; }
    }
}
