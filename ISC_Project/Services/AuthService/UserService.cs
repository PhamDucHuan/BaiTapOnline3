using ISC_Project.Data;
using Microsoft.EntityFrameworkCore;
using ISC_Project.Interface.AuthService;

namespace ISC_Project.Services.AuthService
{
    public class UserService : IUserService
    {
        private readonly ISC_ProjectDbContext _context;

        public UserService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdateUserRoleAsync(int targetUserId, int newRoleId, int currentUserId)
        {
            // 1. Ngăn Admin tự thay đổi vai trò của chính mình
            if (targetUserId == currentUserId)
            {
                throw new ArgumentException("Bạn không thể tự thay đổi vai trò của chính mình.");
            }

            // 2. Tìm người dùng mục tiêu và kiểm tra vai trò hiện tại của họ
            var targetUser = await _context.Users
                                           .Include(u => u.Role) // Lấy thông tin Role kèm theo
                                           .FirstOrDefaultAsync(u => u.UserId == targetUserId);

            if (targetUser == null)
            {
                throw new KeyNotFoundException("Không tìm thấy người dùng cần thay đổi vai trò.");
            }

            // 3. Ngăn Admin thay đổi vai trò của một Admin khác
            if (targetUser.Role?.RoleName == "Admin")
            {
                throw new ArgumentException("Không thể thay đổi vai trò của một Admin khác.");
            }

            // 4. Kiểm tra vai trò mới có tồn tại không
            var newRole = await _context.Roles.FindAsync(newRoleId);
            if (newRole == null)
            {
                throw new KeyNotFoundException("Vai trò mới không hợp lệ.");
            }

            // 5. Cập nhật và lưu
            targetUser.RoleId = newRoleId;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
