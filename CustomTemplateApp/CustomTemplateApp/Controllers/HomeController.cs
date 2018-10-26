using CustomTemplateApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomTemplateApp.Controllers
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
        public ActionResult Display()
        {
            Book book = new Book { Name = "Война и мир", Id = 1, Price = 23.8m };
            return View(book);
        }

        public ActionResult Edit()
        {
            Book book = new Book { Name = "Война и мир", Id = 1, Price = 23.8m };
            return View(book);
        }

        public ActionResult Details ()
        {
            return View();
        }

        public ActionResult MyTemplate()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}