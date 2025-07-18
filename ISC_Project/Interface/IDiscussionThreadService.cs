using ISC_Project.DTOs.DiscussionThreads;
using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IDiscussionThreadService
    {
        Task<DiscussionThread?> GetByIdAsync(int discussionThreadId);
        Task<IEnumerable<DiscussionThread>> GetAllAsync();
        Task<DiscussionThread> CreateAsync(CreateDiscussionThreadDto dto);
        Task<DiscussionThread?> UpdateAsync(int discussionThreadId, CreateDiscussionThreadDto dto);
    }
}
