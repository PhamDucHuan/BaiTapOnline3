namespace ISC_Project.DTOs.UserManagement
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string Status { get; set; } = null!;
        public string RoleName { get; set; } = null!;
    }
}
