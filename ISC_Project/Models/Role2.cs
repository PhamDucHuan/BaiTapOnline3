using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Role2
    {
        public Role2()
        {
            AllowAccesses = new HashSet<AllowAccess>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<AllowAccess> AllowAccesses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
