using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Permission
    {
        public int PermissionsId { get; set; }
        public string? FeatureName { get; set; }
        public string? ActionName { get; set; }
        public string? Description { get; set; }
    }
}
