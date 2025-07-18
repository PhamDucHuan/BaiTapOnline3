using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface IClassHistoryService
    {
        Task<ClassHistory> CreateHistoryAsync(ClassHistory history);
        Task<ClassHistorySession> AddSessionAsync(ClassHistorySession session);
        Task<IEnumerable<ClassHistory>> GetHistoryByClassAsync(int classId);
        Task<IEnumerable<ClassHistorySession>> GetSessionsByHistoryAsync(int historyId);
    }
}
