using ISC_Project.Data;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class ClassHistoryService : IClassHistoryService
    {
        private readonly ISC_ProjectDbContext _context;

        public ClassHistoryService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<ClassHistory> CreateHistoryAsync(ClassHistory history)
        {
            _context.ClassHistories.Add(history);
            await _context.SaveChangesAsync();
            return history;
        }

        public async Task<ClassHistorySession> AddSessionAsync(ClassHistorySession session)
        {
            _context.ClassHistorySessions.Add(session);
            await _context.SaveChangesAsync();
            return session;
        }

        public async Task<IEnumerable<ClassHistory>> GetHistoryByClassAsync(int classId)
        {
            return await _context.ClassHistories.Where(h => h.ClassId == classId).ToListAsync();
        }

        public async Task<IEnumerable<ClassHistorySession>> GetSessionsByHistoryAsync(int historyId)
        {
            return await _context.ClassHistorySessions.Where(s => s.HistoryId == historyId).ToListAsync();
        }
    }
}
