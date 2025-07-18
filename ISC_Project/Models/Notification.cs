using System;
using System.Collections.Generic;

namespace ISC_Project.Models
{
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public string? ReceivingObject { get; set; }
        public string? Title { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UserId { get; set; }

        public virtual User1? User { get; set; }
    }
}
