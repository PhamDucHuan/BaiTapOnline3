using ISC_Project.Data;
using ISC_Project.DTOs.LiveSession;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class LiveSessionService : ILiveSessionService
    {
        private readonly ISC_ProjectDbContext _context;

        public LiveSessionService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<LiveSession?> GetByIdAsync(int liveSessionId) => await _context.LiveSessions.FindAsync(liveSessionId);

        public async Task<IEnumerable<LiveSession>> GetAllAsync() => await _context.LiveSessions.AsNoTracking().ToListAsync();

        public async Task<LiveSession> CreateAsync(CreateLiveSessionDto dto)
        {
            var newLiveSession = new LiveSession
            {
                TeachingId = dto.TeachingId,
                ScheduledStartTime = dto.ScheduledStartTime,
                ActualStartTime = dto.ActualStartTime,
                ActualEndTime = dto.ActualEndTime,
                Status = dto.Status,
                RecordingUrl = dto.RecordingUrl,
            };
            _context.LiveSessions.Add(newLiveSession);
            await _context.SaveChangesAsync();
            return newLiveSession;
        }

        public async Task<LiveSession?> UpdateAsync(int LiveSessionId, CreateLiveSessionDto dto)
        {
            var liveSession = await _context.LiveSessions.FindAsync();
            if (liveSession == null) return null;

            liveSession.TeachingId = dto.TeachingId;
            liveSession.ScheduledStartTime = dto.ScheduledStartTime;
            liveSession.ActualStartTime = dto.ActualStartTime;
            liveSession.ActualEndTime = dto.ActualEndTime;
            liveSession.Status = dto.Status;
            liveSession.RecordingUrl = dto.RecordingUrl;

            await _context.SaveChangesAsync();
            return liveSession;
        }
    }
}
