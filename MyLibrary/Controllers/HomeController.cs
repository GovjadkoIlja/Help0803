using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLibrary.Models;

namespace MyLibrary.Controllers
{
    public class HomeController : Controller
    {
        private BookContext db = new BookContext();

        // GET: Home
        public ActionResult Index()
        {
            Book book1 = new Book { name = "jskajsa]a", author = "jskahdna", year = 1234 };
            db.books.Add(book1);
            return View();
        }

        [HttpPost]
        public ActionResult Index(Book newbook)
        {
            if (ModelState.IsValid)
            {
                db.books.Add(newbook);
                db.SaveChanges();
            }
            return RedirectToAction("Print");
        }

        public ActionResult Print()
        {
            return View();
        }
    }
}