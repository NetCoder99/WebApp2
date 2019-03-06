using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.Models;
using WebApp2.Models.Account;
using WebApp2.Models.Contact;

namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(PersonModel person)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult PersonAjax()
        {
            return View();
        }


        [HttpPost]
        public JsonResult PersonAjax(PersonModel person)
        {
            int personId = person.PersonId;
            string name = person.Name;
            string gender = person.Gender;
            string city = person.City;
            return Json(person);
        }



    }
}