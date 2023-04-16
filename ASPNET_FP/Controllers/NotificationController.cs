using ASPNET_FP.Data;
using ASPNET_FP.Models;
using ASPNET_FP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ASPNET_FP.Controllers
{
	
	public class NotificationController : Controller
    {
        private readonly MyLesseeDBContext myLesseeDBContext;

        public NotificationController(MyLesseeDBContext myLesseeDBContext)
        {
            this.myLesseeDBContext = myLesseeDBContext;

            
        }
        [HttpGet]	
		public IActionResult Index(List<NotificationViewModel> notification)
		{
			if (ModelState.IsValid) 
			{
				var myNotifications = myLesseeDBContext.Notifications.OrderBy(notif => notif.CreationTime).ToList();

                //Create new list to store all notification view models
				List<NotificationViewModel> notificationViewModels = new List<NotificationViewModel>();

                foreach (var myNotification in myNotifications)
				{
                    //Match sender of the notification with the account, retrieve name 
                    var retrievedSenderInfo= myLesseeDBContext.Accounts.Where(account=> account.AcctId == myNotification.SenderId).First();

                    var retrievedReceiverName= myLesseeDBContext.Accounts.Where(account => account.AcctId == myNotification.ReceiverId).First().Name;
                    Debug.WriteLine("My Notification Note ID : "+myNotification.NoteId);
                    //Create a NotificationViewModel with information from notification and Account
                    NotificationViewModel notificationViewModel = new NotificationViewModel
                    {
                        ReceiverName = retrievedReceiverName,
                        SenderName = retrievedSenderInfo.Name,
                        NoteId = myNotification.NoteId,
                        NotificationString = myNotification.NotificationString,
                        CreationTime = DateTime.Now,
                        SenderID = retrievedSenderInfo.AcctId
                    };

                    //Add to list of notifications view models
                    notificationViewModels.Add(notificationViewModel);
                }
				return View(notificationViewModels);
			}else
			{
				return View();
			}
		}

     
        
      public ActionResult Delete(int noteID)
        {
            //Find the notification based on ID and remove it from the database.
            var note = myLesseeDBContext.Notifications.Find(noteID);
            myLesseeDBContext.Notifications.Remove(note);
            myLesseeDBContext.SaveChanges();
            return RedirectToAction("Index", "Notification");

        }

	}
}
