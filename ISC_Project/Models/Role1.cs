using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Role1
    {
        public Role1()
        {
            User1s = new HashSet<User1>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? Description { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<User1> User1s { get; set; }
    }
}
