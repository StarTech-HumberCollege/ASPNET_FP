using ASPNET_FP.Data;
using ASPNET_FP.Models;
using ASPNET_FP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNET_FP.Controllers
{
    public class MessageController : Controller
    {
        private readonly MyLesseeDBContext myLesseeDBContext;

        public MessageController(MyLesseeDBContext myLesseeDBContext)
        {
            this.myLesseeDBContext = myLesseeDBContext;


        }
        [HttpGet]
        public IActionResult Index(List<MessageViewModel> notification)
        {
            if (ModelState.IsValid)
            {
                var myNotifications = myLesseeDBContext.Messages.OrderBy(notif => notif.CreationTime).ToList();

                //Create new list to store all notification view models
                List<MessageViewModel> messageViewModels = new List<MessageViewModel>();

                foreach (var myNotification in myNotifications)
                {
                    //Match sender of the notification with the account, retrieve name 
                    var retrievedSenderInfo = myLesseeDBContext.Accounts.Where(account => account.AcctId == myNotification.SenderID).First();

                    var retrievedReceiverName = myLesseeDBContext.Accounts.Where(account => account.AcctId == myNotification.ReceiverID).First().Name;
                    
                    //Create a NotificationViewModel with information from notification and Account
                    MessageViewModel messageViewModel = new MessageViewModel
                    {
                        ReceiverName = retrievedReceiverName,
                        SenderName = retrievedSenderInfo.Name,
                        MessageID = myNotification.MessageID,
                        MessageString = myNotification.MessageString,
                        CreationTime = DateTime.Now,
                        SenderID = retrievedSenderInfo.AcctId
                    };

                    //Add to list of notifications view models
                    messageViewModels.Add(messageViewModel);
                }
                return View(messageViewModels);
            }
            else
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
