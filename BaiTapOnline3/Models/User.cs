using System.Data;

namespace BaiTapOnline3.Models
{
    // 
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Lưu mật khẩu đã hash
        public int RoleId { get; set; } // Khóa ngoại
        public Role Role { get; set; } // Navigation property
    }
}
