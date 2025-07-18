using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.UserManagement
{
    public class UpdateUserDto
    {
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public int RoleId { get; set; }
    }
}
