using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class ClassroomSetting
    {
        public int ClassroomSettingsId { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
    }
}
