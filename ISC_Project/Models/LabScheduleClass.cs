using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class LabScheduleClass
    {
        public int? LabSchedulesId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual LabSchedule? LabSchedules { get; set; }
    }
}
