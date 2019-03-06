using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.DataConnections;
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
            //using (var ctx = new UserAccountDB())
            //{
            //    var query = from st in ctx.LoginCreds
            //                where st.UserName == model.UserName
            //                select st;
            //    if (query.Count() > 0)
            //    {
            //        LoginCreds user = query.FirstOrDefault<LoginCreds>();
            //        user.LoginAttempts++;
            //        ctx.SaveChanges();
            //    }
            //    else
            //    {
            //        var login_creds = new LoginCreds() { UserName = model.UserName, PassWord = model.PassWord };
            //        ctx.LoginCreds.Add(login_creds);
            //        ctx.SaveChanges();
            //    }

            //}
            //System.Threading.Thread.Sleep(500);
            return View();
        }


        [HttpGet]
        public ActionResult EditAccount(int ID = -1)
        {
            if (ID > -1)
            {
                UserAccountDB userAccountDB = new UserAccountDB();
                UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
                user_dtls.PassWordConfirm = user_dtls.PassWord;
                return View(user_dtls);
            }
            else
            {
                return View(new UserAccount());
            }

        }

        [HttpPost]
        public ActionResult EditAccount(UserAccount model)
        {
            using (UserAccountDB userAccountDB = new UserAccountDB())
            {
                userAccountDB.Configuration.ValidateOnSaveEnabled = false;
                UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == model.UserDetailId).First();
                userAccountDB.Entry(user_dtls).CurrentValues.SetValues(model);
                userAccountDB.SaveChanges();
                return View(user_dtls);
            }
        }

        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult CreateAccount(int ID = -1)
        {
            if (ID > -1)
            {
                UserAccountDB userAccountDB = new UserAccountDB();
                UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
                return View(user_dtls);
            }
            else
            {
                return View(new UserAccount());
            }

        }
        [HttpPost]
        public ActionResult CreateAccount(UserAccount model)
        {
            using (UserAccountDB userAccountDB = new UserAccountDB())
            {
                userAccountDB.UserDetails.Add(model);
                userAccountDB.SaveChanges();
                return View(model);
            }
        }

        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult ManageAccounts()
        {
            UserAccountDB userAccountDB = new UserAccountDB();
            List<UserAccount> model = userAccountDB.UserDetails.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult ManageAccounts(UserAccount model)
        {
            System.Threading.Thread.Sleep(500);
            return View(model);
        }

        public ActionResult Edit(int ID)
        {
            return RedirectToAction("CreateAccount", "Account", new { ID = ID });
        }

        public ActionResult Delete(int ID)
        {
            UserAccountDB userAccountDB = new UserAccountDB();
            UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
            userAccountDB.UserDetails.Remove(user_dtls);
            userAccountDB.SaveChanges();
            return View("ManageAccounts", userAccountDB.UserDetails.ToList());
        }

    }
}
