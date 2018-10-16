using Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            var books = db.Books;
            //SelectList authors = new SelectList(db.Books, "Author", "Name");
            //ViewBag.Authors = authors;
            return View(db.Books);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //[HttpPost]
        //public string GetForm(string author)
        //{
        //    return author;
        //}

        //public string GetForm(string[] countries)
        //{
        //    string result = "";
        //    foreach (string c in countries)
        //    {
        //        result += c;
        //        result += ";";
        //    }
        //    return "Вы выбрали: " + result;
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}


        //[HttpPost]
        //public string GetForm(string text)
        //{
        //    return text;
        //}

        //[HttpPost]
        //public string GetForm(string color)
        //{
        //    return color;
        //}

        //[HttpPost]
        //public string GetForm(bool set)
        //{
        //    return set.ToString();
        //}
    }
}