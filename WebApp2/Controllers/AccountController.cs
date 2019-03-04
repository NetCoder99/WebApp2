using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.Models.Account;
using WebApp2.Models.Addresses;

namespace WebApp2.Controllers
{
    public class AccountController : Controller
    {
        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult Login()
        {
            LoginCreds model = new LoginCreds() { UserName = "dugger01@cox.net", PassWord = "Not Set" };
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginCreds model)
        {
            using (var ctx = new AccountDb())
            {
                var query = from st in ctx.LoginCreds
                            where st.UserName == model.UserName
                            select st;
                if (query.Count() > 0)
                {
                    LoginCreds user = query.FirstOrDefault<LoginCreds>();
                    user.LoginAttempts++;
                    ctx.SaveChanges();
                }
                else
                {
                    var login_creds = new LoginCreds() { UserName = model.UserName, PassWord = model.PassWord };
                    ctx.LoginCreds.Add(login_creds);
                    ctx.SaveChanges();
                }

            }
            System.Threading.Thread.Sleep(500);
            return View();
        }



        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult CreateAccount()
        {

            UserAccount model = new UserAccount();
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateAccount(UserAccount model)
        {
            System.Threading.Thread.Sleep(500);
            return View(model);
        }

    }
}
