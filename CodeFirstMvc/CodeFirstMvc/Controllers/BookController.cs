using CodeFirstMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMvc.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Book b)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BookContext>());
            BookContext context = new BookContext();
            context.Books.Add(b);
            context.SaveChanges();
            return View();
        }
    }
}