using System.ComponentModel.DataAnnotations;

namespace ISC_Project.DTOs.UserManagement
{
    public record RegisterRequestDto(
    [Required] string Username,
    [Required] string Password,
    [Required] string FullName,
    [Required] string Email
    );
}
