namespace ASPNET_FP.Models
{
	public class Message
	{
		public int NoteID { get; set; }
		public int ReceiverID { get; set; }
		public int SenderID { get; set; }
		public DateTime CreationTime { get; set; }
		public string Notification { get; set; }

		public Message()
		{

		}
		public Message(int noteID, int receiverID, int senderID, DateTime creationTime, string notification)
		{
			this.NoteID = noteID;
			this.ReceiverID = receiverID;
			this.SenderID = senderID;
			this.CreationTime = creationTime;
			this.Notification = notification;
		}
	}
}
