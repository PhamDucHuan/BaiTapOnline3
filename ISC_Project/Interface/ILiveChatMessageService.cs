using ISC_Project.DTOs.LiveChatMessage;
using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface ILiveChatMessageService
    {
        Task<LiveChatMessage?> GetByIdAsync(int liveMessageId);
        Task<IEnumerable<LiveChatMessage>> GetAllAsync();
        Task<LiveChatMessage> CreateAsync(CreateLiveChatMessageDto dto);
        Task<LiveChatMessage?> UpdateAsync(int liveMessageId, CreateLiveChatMessageDto dto);
        Task<bool> DeleteAsync(int liveMessageId);
    }
}
