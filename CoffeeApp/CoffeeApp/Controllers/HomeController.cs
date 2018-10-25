using CoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace CoffeeApp.Controllers
{
    public class HomeController : Controller
    {
        CoffeeContext db = new CoffeeContext();

        public ActionResult Index()
        {
            IEnumerable<Coffee> drinks = db.Coffees;            
            return View(drinks);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Coffee coffee = db.Coffees.Find(id);
            if (coffee != null)
            {
                return View(coffee);                
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(Coffee coffee)
        {            
            db.Entry(coffee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Coffee cf = db.Coffees.Find(id);
            if (cf == null)
            {
                return HttpNotFound();
            }
            return View(cf);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Coffee cf = db.Coffees.Find(id);
            if (cf == null)
            {
                return HttpNotFound();
            }
            db.Coffees.Remove(cf);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}