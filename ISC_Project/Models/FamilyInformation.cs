using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class FamilyInformation
    {
        public string? FamilyName { get; set; }
        public DateTime? BirthOfFamily { get; set; }
        public string? JobFamily { get; set; }
        public string? PhoneFamily { get; set; }
        public string? FamilyType { get; set; }
        public int? UserId { get; set; }

        public virtual User1? User { get; set; }
    }
}
