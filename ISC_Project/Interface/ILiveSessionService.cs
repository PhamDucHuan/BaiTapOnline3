using ISC_Project.DTOs.LiveSession;
using ISC_Project.Models;


namespace ISC_Project.Interface
{
    public interface ILiveSessionService
    {
        Task<LiveSession?> GetByIdAsync(int liveSessionId);
        Task<IEnumerable<LiveSession>> GetAllAsync();
        Task<LiveSession> CreateAsync(CreateLiveSessionDto dto);
        Task<LiveSession?> UpdateAsync(int liveSessionId, CreateLiveSessionDto dto);
    }
}
