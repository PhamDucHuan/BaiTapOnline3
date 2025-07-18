using ISC_Project.Data;
using ISC_Project.DTOs.DiscussionThreads;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ISC_Project.Services
{
    public class DiscussionThreadService : IDiscussionThreadService
    {
        private readonly ISC_ProjectDbContext _context;

        public DiscussionThreadService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<DiscussionThread?> GetByIdAsync(int DiscussionThreadId) => await _context.DiscussionThreads.FindAsync(DiscussionThreadId);

        public async Task<IEnumerable<DiscussionThread>> GetAllAsync() => await _context.DiscussionThreads.AsNoTracking().ToListAsync();

        public async Task<DiscussionThread> CreateAsync(CreateDiscussionThreadDto dto)
        {
            var newDiscussionThread = new DiscussionThread
            {
                UserId = dto.UserId,
                TeachingId = dto.TeachingId,
                Title = dto.Title,
                Visibility = dto.Visibility,
                ViewCount = dto.ViewCount,
                CreateAt = dto.CreateAt,
                IsResolved = dto.IsResolved
            };
            _context.DiscussionThreads.Add(newDiscussionThread);
            await _context.SaveChangesAsync();
            return newDiscussionThread;
        }

        public async Task<DiscussionThread?> UpdateAsync(int DiscussionThreadId, CreateDiscussionThreadDto dto)
        {
            var discussionThread = await _context.DiscussionThreads.FindAsync();
            if (discussionThread == null) return null;


            discussionThread.UserId = dto.UserId;
            discussionThread.TeachingId = dto.TeachingId;
            discussionThread.Title = dto.Title;
            discussionThread.Visibility = dto.Visibility;
            discussionThread.ViewCount = dto.ViewCount;
            discussionThread.CreateAt = dto.CreateAt;
            discussionThread.IsResolved = dto.IsResolved;

            await _context.SaveChangesAsync();
            return discussionThread;
        }

    }
}

