using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Registration
    {
        public Registration()
        {
            RelativesInformations = new HashSet<RelativesInformation>();
        }

        public int RegistrationsId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? CourserName { get; set; }
        public string? Campus { get; set; }
        public string? StudentName { get; set; }
        public DateOnly? BirdDay { get; set; }
        public string? Sex { get; set; }
        public string? Nationality { get; set; }
        public string? EducationLevel { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PaymentStatus { get; set; }
        public string? RegistrationsImageUrl { get; set; }
        public int? StudentUserId { get; set; }
        public int? CourseOfferingsId { get; set; }

        public virtual CourseOffering? CourseOfferings { get; set; }
        public virtual User1? StudentUser { get; set; }
        public virtual ICollection<RelativesInformation> RelativesInformations { get; set; }
    }
}
