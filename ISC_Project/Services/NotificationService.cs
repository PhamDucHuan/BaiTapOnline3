using ISC_Project.Data;
using ISC_Project.Interface;
using ISC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ISC_Project.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ISC_ProjectDbContext _context;

        public NotificationService(ISC_ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<Notification> CreateNotificationAsync(Notification notification)
        {
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
            return notification;
        }

        public async Task<IEnumerable<Notification>> GetAllNotificationsAsync()
        {
            return await _context.Notifications.ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetByReceivingObjectAsync(string receivingObject)
        {
            return await _context.Notifications.Where(n => n.ReceivingObject == receivingObject).ToListAsync();
        }
    }
}
