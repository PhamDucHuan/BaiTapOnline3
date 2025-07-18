using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class RelativesInformation
    {
        public int RelativesInformationId { get; set; }
        public string? RelativesName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public int? RegistrationsId { get; set; }

        public virtual Registration? Registrations { get; set; }
    }
}
