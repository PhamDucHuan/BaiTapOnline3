namespace ISC_Project.Interface.AuthService
{
    public record UpdateRoleRequestDto(int NewRoleId);
    public interface IUserService
    {
        // Chỉ cần ID người dùng mục tiêu và ID vai trò mới
        Task<bool> UpdateUserRoleAsync(int targetUserId, int newRoleId, int currentUserId);
    }
}
