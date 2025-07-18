using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class LabGrader
    {
        public int? LabSchedulesId { get; set; }
        public int? UserId { get; set; }

        public virtual LabSchedule? LabSchedules { get; set; }
        public virtual User1? User { get; set; }
    }
}
