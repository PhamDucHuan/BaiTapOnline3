using BaiTapOnline3.Data;
using BaiTapOnline3.Interface;
using BaiTapOnline3.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapOnline3.Services
{
    public class UserService : IUserService
    {
        private readonly Project_Online3DBContext _context;

        public UserService(Project_Online3DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<object>> GetUsersAsync()
        {
            return await _context.Users
                .Select(u => new { u.UserId, u.FullName, u.Username, u.RoleId })
                .ToListAsync();
        }

        public async Task<object> GetUserAsync(int id)
        {
            return await _context.Users
                .Where(u => u.UserId == id)
                .Select(u => new { u.UserId, u.FullName, u.Username, u.RoleId })
                .FirstOrDefaultAsync();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            // TODO: Hash mật khẩu trước khi lưu
            // user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> UpdateUserAsync(int id, User user)
        {
            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(e => e.UserId == id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}