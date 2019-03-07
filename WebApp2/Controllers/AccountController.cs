using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            LoginCreds model = new LoginCreds() { UserName = "dugger01@cox.net" };
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginCreds model)
        {
            System.Threading.Thread.Sleep(500);
            using (UserAccountDB userAccountDB = new UserAccountDB())
            {
                List<UserAccount> user_dtls = userAccountDB.UserDetails.Where(w => w.Email == model.UserName).ToList();
                if (user_dtls.Count() == 0)
                {
                    dynamic errorMessage = new {param1 = "UserName",  param2 = "User Name not found." };
                    HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    return Json(errorMessage, JsonRequestBehavior.AllowGet);
                }
                if (user_dtls.Count() > 1)
                {
                    dynamic errorMessage = new { param1 = "UserName", param2 = "Multiple users found for this account." };
                    HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    return Json(errorMessage, JsonRequestBehavior.AllowGet);
                }
                if (user_dtls[0].PassWord != model.PassWord)
                {
                    dynamic errorMessage = new { param1 = "PassWord", param2 = "Invalid password." };
                    HttpContext.Response.StatusCode = (int)HttpStatusCode.NotAcceptable;
                    return Json(errorMessage, JsonRequestBehavior.AllowGet);
                }

                dynamic successMessage = new { url = Url.Action("Index", "Home") };
                HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(successMessage, JsonRequestBehavior.AllowGet);

            }
        }


        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult CreateAccount(int ID = -1)
        {
            ViewBag.backLink = "Login";
            if (ID > -1)
            {
                using (UserAccountDB userAccountDB = new UserAccountDB())
                {
                    UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
                    return View(user_dtls);
                }
            }
            else
            {
                return View(new UserAccount());
            }

        }
        [HttpPost]
        public ActionResult CreateAccount(UserAccount model)
        {
            ViewBag.backLink = "Login";
            using (UserAccountDB userAccountDB = new UserAccountDB())
            {
                userAccountDB.UserDetails.Add(model);
                userAccountDB.SaveChanges();
                return View(model);
            }
        }
        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult EditAccount(int ID = -1)
        {
            if (ID > -1)
            {
                using (UserAccountDB userAccountDB = new UserAccountDB())
                {
                    UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
                    user_dtls.PassWordConfirm = user_dtls.PassWord;
                    return View(user_dtls);
                }
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
                ViewBag.backLink = "MagaeAccounts";
                return View(user_dtls);
            }
        }


        // -------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult ManageAccounts(string deleteMsg = null)
        {
            using (UserAccountDB userAccountDB = new UserAccountDB())
            {
                List<UserAccount> model = userAccountDB.UserDetails.ToList();
                if (deleteMsg != null)
                { ViewBag.deleteMsg = deleteMsg; }
                return View(model);
            }
        }

        public ActionResult DeleteAccount(int ID)
        {
            using (UserAccountDB userAccountDB = new UserAccountDB())
            {
                UserAccount user_dtls = userAccountDB.UserDetails.Where(w => w.UserDetailId == ID).First();
                string lcldeleteMsg = "Account was deleted: " + user_dtls.Email;
                userAccountDB.UserDetails.Remove(user_dtls);
                userAccountDB.SaveChanges();
                ViewBag.deleteMsg = "Account was deleted";
                return RedirectToAction("ManageAccounts", new { deleteMsg = lcldeleteMsg });
            }
        }

    }
}
