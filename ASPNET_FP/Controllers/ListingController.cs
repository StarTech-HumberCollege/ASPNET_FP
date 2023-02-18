using Microsoft.AspNetCore.Mvc;

namespace ASPNET_FP.Controllers
{
	public class ListingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
