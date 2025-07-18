namespace ISC_Project.DTOs.UserManagement
{
    public class RoleDto
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsAdmin { get; set; }
    }
}
