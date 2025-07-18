using ISC_Project.Data;
using ISC_Project.DTOs.LiveChatMessage;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ISC_Project.Services
{
    public class LiveChatMessageService : ILiveChatMessageService
    {
        private readonly ISC_ProjectDbContext _context;

        public LiveChatMessageService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<LiveChatMessage?> GetByIdAsync(int liveChatMessageId) => await _context.LiveChatMessages.FindAsync(liveChatMessageId);

        public async Task<IEnumerable<LiveChatMessage>> GetAllAsync() => await _context.LiveChatMessages.AsNoTracking().ToListAsync();

        public async Task<LiveChatMessage> CreateAsync(CreateLiveChatMessageDto dto)
        {
            var newLiveChatMessage = new LiveChatMessage
            {
                UserId = dto.UserId,
                LiveSessionsId = dto.LiveSessionId,
                MessageContent = dto.MessageContent,
                IsPinned = dto.IsPinned,
                RecordingUrl=dto.recording_url,
                SentAt = dto.SentAt,
                MessageType = dto.MessageType,
                Status = dto.Status
            };
            _context.LiveChatMessages.Add(newLiveChatMessage);
            await _context.SaveChangesAsync();
            return newLiveChatMessage;
        }

        public async Task<LiveChatMessage?> UpdateAsync(int liveChatMessageId, CreateLiveChatMessageDto dto)
        {
            var liveChatMessage = await _context.LiveChatMessages.FindAsync();
            if (liveChatMessage == null) return null;


            liveChatMessage.UserId = dto.UserId;
            liveChatMessage.LiveSessionsId = dto.LiveSessionId;
            liveChatMessage.MessageContent = dto.MessageContent;
            liveChatMessage.IsPinned = dto.IsPinned;
            liveChatMessage.RecordingUrl = dto.recording_url;
            liveChatMessage.SentAt = dto.SentAt;
            liveChatMessage.MessageType = dto.MessageType;
            liveChatMessage.Status = dto.Status;

            await _context.SaveChangesAsync();
            return liveChatMessage;
        }

        public async Task<bool> DeleteAsync(int liveChatMessageId)
        {
            var liveChatMessage = await _context.LiveChatMessages.FindAsync(liveChatMessageId);
            if (liveChatMessage == null) return false;

            _context.LiveChatMessages.Remove(liveChatMessage);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

