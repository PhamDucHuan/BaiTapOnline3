using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.UserManagement
{
    public class CreateUserDto
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        [MinLength(6)]
        public string Password { get; set; } = null!;
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public int RoleId { get; set; }
    }
}
