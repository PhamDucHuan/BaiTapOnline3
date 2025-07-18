using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class RolePermission
    {
        public int? RoleId { get; set; }
        public int? PermissionsId { get; set; }

        public virtual Permission? Permissions { get; set; }
        public virtual Role1? Role { get; set; }
    }
}
