using ISC_Project.Models;

namespace ISC_Project.Interface
{
    public interface INotificationService
    {
        Task<Notification> CreateNotificationAsync(Notification notification);
        Task<IEnumerable<Notification>> GetAllNotificationsAsync();
        Task<IEnumerable<Notification>> GetByReceivingObjectAsync(string receivingObject);
    }
}
