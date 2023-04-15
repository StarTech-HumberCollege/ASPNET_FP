using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models
{
    public class Notification
    {
        [Key]
        [Required]
        public int NoteId { get; set; }
        [Required]
        public int ReceiverId { get; set; }
        [Required]
        public int SenderId { get; set; }

        
        public DateTime CreationTime { get; set; }
        [Required]
        public string NotificationString { get; set; }
    }
}
