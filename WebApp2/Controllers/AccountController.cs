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
        public ActionResult ManageAccounts(string deleteMsg = null)
        {
            UserAccountDB userAccountDB = new UserAccountDB();
            List<UserAccount> model = userAccountDB.UserDetails.ToList();
            if (deleteMsg != null)
            { ViewBag.deleteMsg = deleteMsg; }
            return View(model);
        }

        public ActionResult Edit(int ID)
        {
            return RedirectToAction("CreateAccount", "Account", new { ID = ID });
        }

        public ActionResult DeleteAccount(int ID)
        {
            UserAccountDB userAccountDB = new UserAccountDB();
            UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
            string lcldeleteMsg = "Account was deleted: " + user_dtls.Email;
            userAccountDB.UserDetails.Remove(user_dtls);
            userAccountDB.SaveChanges();
            ViewBag.deleteMsg = "Account was deleted";
            return RedirectToAction("ManageAccounts", new { deleteMsg = lcldeleteMsg });
        }

    }
}
