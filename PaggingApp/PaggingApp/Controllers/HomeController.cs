using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaggingApp.Models;


namespace PaggingApp.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db = new MobileContext();

        public ActionResult Index(int page=1)
        {
            int pageSize = 3;
            IEnumerable<Phone> phonePerPages = db.Phones
                .OrderBy(x => x.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = db.Phones.Count() };
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Phones = phonePerPages };
            return View(ivm);
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
    }
}