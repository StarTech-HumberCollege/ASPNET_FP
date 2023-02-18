using ASPNET_FP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace ASPNET_FP.Controllers
{

	public class AccountController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

		// GET: /<controller>/
		public IActionResult Details() // Account acct
		{
			// create dummy account data
			Account acct1 = new Account();
			acct1.AcctId = 1;
			acct1.Email = "tuyi.chen@humber.ca";
			acct1.Password = "123456";
			acct1.Phone = 6476471770;
			acct1.Name = "Tuyi Chen";

			return View(acct1);
		}
	}

}
