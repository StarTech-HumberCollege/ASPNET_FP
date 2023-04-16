using ASPNET_FP.Data;
using ASPNET_FP.Migrations;
using ASPNET_FP.Models;
using Microsoft.AspNetCore.Identity;
using ASPNET_FP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System.Diagnostics;
using Microsoft.IdentityModel.Tokens;

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

        // ************************************************* LOGIN SECTION ************************************************* 
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(String email = "")
        {
            var model = new LoginViewModel(email);
            return View(model);

        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            string email = loginViewModel.Email;
            string password = loginViewModel.Password;


            if (ModelState.IsValid)
            {

                var myAccount = myLesseeDBContext.Accounts.Where(user => user.Email == loginViewModel.Email).Where(user => user.Password == loginViewModel.Password).ToList();
                if (!myAccount.IsNullOrEmpty())
                {
                    return View("User", myAccount[0]);
                }
                else
                {
                    return View();

                }



            }
            else
            {
                return View();

            }
        }

        // ************************************************* USER SECTION ************************************************* 

        [HttpPost]
        public IActionResult User(Account account)
        {
            if (ModelState.IsValid)
            {
                var emailIsInUse = myLesseeDBContext.Accounts.Where(user => user.Email == account.Email).ToList();
                if (account.AcctId == 0 && emailIsInUse.Count != 0)
                {

                    account.LastLoginTime = DateTime.Now;
                    myLesseeDBContext.Update(account);
                    myLesseeDBContext.SaveChanges();
                }
            }
            return View(account);
        }

        // ************************************************* SIGN UP SECTION *************************************************                   
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Account account)
        {
            if (account.AcctId != 0)
            {
                ViewBag.Success = "created";
                return View();
            }
            else
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
                //Validate email is not in use
                var emailIsInUse = myLesseeDBContext.Accounts.Where(user => user.Email == account.Email).ToList();
                if (account.AcctId == 0 && emailIsInUse.Count == 0)
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
