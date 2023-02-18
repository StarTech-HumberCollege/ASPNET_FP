using Microsoft.AspNetCore.Mvc;

namespace ASPNET_FP.Controllers
{
	public class AppointmentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
