using ASPNET_FP.Data;
using ASPNET_FP.Models;
using Microsoft.AspNetCore.Mvc;

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
		public IActionResult Index(List<Notification> notification)
		{
			if (ModelState.IsValid) 
			{
				var myNotifications = myLesseeDBContext.Notifications.OrderBy(notif => notif.CreationTime).ToList();
				return View(myNotifications);
			}else
			{
				return View();
			}
		}

	}
}
