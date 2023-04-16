using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models.ViewModels
{
    public class NotificationViewModel
    {
        
        [Required]
        public int NoteId { get; set; }
        [Required]
        public string ReceiverName { get; set; }
        [Required]
        public string SenderName { get; set; }
        public int SenderID { get; set; }


        public DateTime CreationTime { get; set; }
        [Required]
        public string NotificationString { get; set; }
    }
}
