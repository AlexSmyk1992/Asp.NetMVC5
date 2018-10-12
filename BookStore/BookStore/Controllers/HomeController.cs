using BookStore.Models;
using BookStore.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Book> books = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;

            HttpContext.Response.Cookies["id"].Value = "ca-4353w";
            Session["name"] = "Tom";
            // возвращаем представление
            return View();
        }

        public ActionResult Edit()
        {               
            // возвращаем представление
            return View("~/Views/MyViewEdit/Edit.cshtml");
        }
        public ActionResult ViewList()
        {
            // возвращаем представление
            //return View("~/Views/MyViewList/List.cshtml", db.Books);
            return View("~/Views/MyViewList/List.cshtml", db.Books);
        }


        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }

        public string Square(int a = 10, int h = 3)
        {
            /*int a = Int32.Parse(Request.Params["a"]);
              int h = Int32.Parse(Request.Params["h"]); Получение данных из контекста запроса*/
            double s = a * h / 2.0;
            return "<h2>Площадь треугольника с основанием " + a +
                    " и высотой " + h + " равна " + s + "</h2>";
        }

        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }

        public ActionResult GetImage()
        {
            string path = "../Images/1.jpg";
            return new ImageResult(path);
        }

        public ViewResult SomeMethod()
        {
            ViewBag.Head = "Привет мир!";
            return View("SomeView");
        }
        public FileResult GetFile()
        {
            // Путь к файлу
            string file_path = Server.MapPath("~/Files/fontan.jpg");
            // Тип файла - content-type
            string file_type = "application/jpg";
            // Имя файла - необязательно
            string file_name = "fontan.jpg";
            return File(file_path, file_type, file_name);
        }

        public string GetContext()
        {
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
        }
        public string ContextData()
        {
            HttpContext.Response.Write("<h1>Hello World</h1>");

            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
        }
        public string GetName()
        {
            var val = Session["name"];
            return val.ToString();
        }
    }
}