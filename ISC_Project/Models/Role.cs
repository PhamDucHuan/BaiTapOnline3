using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Role
    {
        public Role()
        {
            AllowAccess1s = new HashSet<AllowAccess1>();
            User2s = new HashSet<User2>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;

        public virtual ICollection<AllowAccess1> AllowAccess1s { get; set; }
        public virtual ICollection<User2> User2s { get; set; }
    }
}
