using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models
{
	public class Message
	{
		[Key]
		[Required]
		public int MessageID { get; set; }
		[Required]
        public int ReceiverID { get; set; }
        [Required]
        public int SenderID { get; set; }
		public DateTime CreationTime { get; set; }
        [Required]
        public string MessageString { get; set; }

		public Message()
		{

		}
		public Message(int noteID, int receiverID, int senderID, DateTime creationTime, string notification)
		{
			this.MessageID = noteID;
			this.ReceiverID = receiverID;
			this.SenderID = senderID;
			this.CreationTime = creationTime;
			this.MessageString = notification;
		}
	}
}
