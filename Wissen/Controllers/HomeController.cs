using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wissen.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string firstName, string lastName, string email, string phone, string message, string subject)
        {
            // TODO: Mail gönderme işlemi yapılacak

            ViewBag.Message = "Form başarıyla iletildi, en kısa zamanda dönüş yapacağız.";
            return View();
        }
    }
}