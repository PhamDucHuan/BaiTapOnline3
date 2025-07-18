using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class AllowAccess1
    {
        public int AllowAccessId { get; set; }
        public string TableName { get; set; } = null!;
        public string AccessProperties { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
