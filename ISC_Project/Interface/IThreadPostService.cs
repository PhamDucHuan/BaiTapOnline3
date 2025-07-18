
using ISC_Project.DTOs.ThreadPost;
using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IThreadPostService
    {
        Task<ThreadPost?> GetByIdAsync(int threadPostId);
        Task<IEnumerable<ThreadPost>> GetAllAsync();
        Task<ThreadPost> CreateAsync(CreateThreadPostDto dto);
        Task<ThreadPost?> UpdateAsync(int threadPostId, CreateThreadPostDto dto);
        Task<bool> DeleteAsync(int threadPostId);
    }
}
