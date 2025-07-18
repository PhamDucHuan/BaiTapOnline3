using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public int RoleId { get; set; }

        public virtual Role2 Role { get; set; } = null!;
    }
}
