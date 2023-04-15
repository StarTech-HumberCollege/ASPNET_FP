using ASPNET_FP.Data;
using ASPNET_FP.Migrations;
using ASPNET_FP.Models;
using Microsoft.AspNetCore.Identity;
using ASPNET_FP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System.Diagnostics;

namespace ASPNET_FP.Controllers
{

    public class AccountController : Controller
    {
        private readonly MyLesseeDBContext myLesseeDBContext;
        private UserManager<Account> accountManager;
        private SignInManager<Account> signInManager;
        public AccountController(MyLesseeDBContext myLesseeDBContext)
        {
            this.myLesseeDBContext = myLesseeDBContext;

            //this.myLesseeDBContext = myLesseeDBContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(String email = "")
        {
            var model = new LoginViewModel { Email = email };
            return View(model);

        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            string email = loginViewModel.Email;
            string password = loginViewModel.Password;


            if (ModelState.IsValid)
            {
                var myAccount = myLesseeDBContext.Accounts.Where(user => user.Email == loginViewModel.Email).ToList();

                //Send an Account object with the data
                ViewBag.Account = myAccount[0];

                return View("User");


            }
            else
            {
                return View();

            }
        }


        [HttpGet]
        public IActionResult User()
        {
            return View();
        }

                           
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Account account)
        {
            if(account.AcctId != 0)
            {
                ViewBag.Success = "created";
                return View();
            }else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Account account)
        {
            //Add new account to Database
            if (ModelState.IsValid)
            {
                if (account.AcctId == 0)
                {
                    account.CreationTime = DateTime.Now;
                    account.LastLoginTime = DateTime.Now;
                    await myLesseeDBContext.AddAsync(account);
                    await myLesseeDBContext.SaveChangesAsync();
                }
            }
           
            return View("SignUp");


        }


    }

}
