using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models.ViewModels
{
    public class MessageViewModel
    {

        [Required]
        public int MessageID { get; set; }
        [Required]
        public int ReceiverID { get; set; }
        [Required]
        public int SenderID { get; set; }
        public string ReceiverName { get; set; }
        
        public string SenderName { get; set; }
        public DateTime CreationTime { get; set; }
        [Required]
        public string MessageString { get; set; }
    }
}
