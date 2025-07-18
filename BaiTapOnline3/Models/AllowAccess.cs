using System.ComponentModel.DataAnnotations.Schema;

namespace BaiTapOnline3.Models
{
    public class AllowAccess
    {
        public int Id { get; set; }
        public int RoleId { get; set; } // Khóa ngoại
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
        public string TableName { get; set; } = string.Empty;
        public string AccessProperties { get; set; } = string.Empty; // Ví dụ: "InternName,DateOfBirth,Major"
    }
}
