using ISC_Project.Data;
using ISC_Project.DTOs.ThreadPost;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ISC_Project.Services
{
    public class ThreadPostService : IThreadPostService
    {
        private readonly ISC_ProjectDbContext _context;

        public ThreadPostService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<ThreadPost?> GetByIdAsync(int threadPostId) => await _context.ThreadPosts.FindAsync(threadPostId);

        public async Task<IEnumerable<ThreadPost>> GetAllAsync() => await _context.ThreadPosts.AsNoTracking().ToListAsync();

        public async Task<ThreadPost> CreateAsync(CreateThreadPostDto dto)
        {
            var newThreadPost = new ThreadPost
            {
                UserId = dto.UserId,
                DiscussionId = dto.DiscussionId,
                Content = dto.Content,
                CreatedAt = dto.CreatedAt,
                AttachmentUrl = dto.AttachmentUrl
            };
            _context.ThreadPosts.Add(newThreadPost);
            await _context.SaveChangesAsync();
            return newThreadPost;
        }

        public async Task<ThreadPost?> UpdateAsync(int threadPostId, CreateThreadPostDto dto)
        {
            var threadPost = await _context.ThreadPosts.FindAsync();
            if (threadPost == null) return null;


            threadPost.UserId = dto.UserId;
            threadPost.DiscussionId = dto.DiscussionId;
            threadPost.Content = dto.Content;
            threadPost.CreatedAt = dto.CreatedAt;
            threadPost.AttachmentUrl = dto.AttachmentUrl;


            await _context.SaveChangesAsync();
            return threadPost;
        }

        public async Task<bool> DeleteAsync(int threadPostId)
        {
            var threadPost = await _context.ThreadPosts.FindAsync(threadPostId);
            if (threadPost == null) return false;

            _context.ThreadPosts.Remove(threadPost);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

