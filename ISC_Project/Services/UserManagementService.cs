using ISC_Project.Data;
using ISC_Project.DTOs.UserManagement;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly ISC_ProjectDbContext _context;

        public UserManagementService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto createUserDto)
        {
            var newUser = new User
            {
                UserName = createUserDto.UserName,
                Password = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password),
                FullName = createUserDto.FullName,
                Email = createUserDto.Email,
                RoleId = createUserDto.RoleId,
                // SỬA Ở ĐÂY: Gán giá trị string trực tiếp
                Status = "Đang hoạt động",
                CreateAt = DateTime.UtcNow
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return (await GetUserByIdAsync(newUser.UserId))!;
        }

        public async Task<UserDto?> UpdateUserAsync(int userId, UpdateUserDto updateUserDto)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return null;

            user.FullName = updateUserDto.FullName;
            user.Email = updateUserDto.Email;
            user.RoleId = updateUserDto.RoleId;
            user.UpdateAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return await GetUserByIdAsync(userId);
        }

        public async Task<bool> DeleteUserSoftAsync(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            // SỬA Ở ĐÂY: Gán giá trị string trực tiếp
            user.Status = "Bị khóa";
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            return await _context.Users
               .AsNoTracking()
               .Include(u => u.Role)
               .Select(u => new UserDto
               {
                   UserId = u.UserId,
                   UserName = u.UserName,
                   FullName = u.FullName,
                   Email = u.Email,
                   Status = u.Status,
                   RoleName = u.Role != null ? u.Role.RoleName : "N/A"
               }).ToListAsync();
        }

        public async Task<UserDto?> GetUserByIdAsync(int userId)
        {
            return await _context.Users
                .AsNoTracking()
                .Include(u => u.Role)
                .Where(u => u.UserId == userId)
                .Select(u => new UserDto
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    FullName = u.FullName,
                    Email = u.Email,
                    Status = u.Status,
                    RoleName = u.Role != null ? u.Role.RoleName : "N/A"
                }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RoleDto>> GetAllRolesAsync()
        {
            return await _context.Roles
                .AsNoTracking()
                .Select(r => new RoleDto
                {
                    RoleId = r.RoleId,
                    RoleName = r.RoleName, // Giờ đây RoleName là string
                    Description = r.Description,
                    IsAdmin = r.IsAdmin ?? false
                }).ToListAsync();
        }
    }
}