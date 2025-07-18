using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class AcceptingSchoolTransfer
    {
        public int AcceptingSchoolTransfersId { get; set; }
        public DateTime? MoveInDate { get; set; }
        public int? SemesterMoveIn { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? ConvertFrom { get; set; }
        public string? Reason { get; set; }
        public string? FileUrl { get; set; }
        public int? UserId { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual User1? User { get; set; }
    }
}
