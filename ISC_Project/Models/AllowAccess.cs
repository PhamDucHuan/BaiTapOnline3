using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class AllowAccess
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string TableName { get; set; } = null!;
        public string AccessProperties { get; set; } = null!;

        public virtual Role2 Role { get; set; } = null!;
    }
}
