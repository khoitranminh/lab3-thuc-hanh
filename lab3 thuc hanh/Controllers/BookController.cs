using lab3_thuc_hanh.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3_thuc_hanh.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Listbook()
        {
            BookManager context = new BookManager();
            var listBook = context.Books.ToList();
            return View(listBook);
        }
        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManager context = new BookManager();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if(book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(Book book)
        {
            BookManager context = new BookManager();
            context.Books.AddOrUpdate(book);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }
        public ActionResult Edit(int id)
        {
            BookManager context = new BookManager();
            Book book = context.Books.SingleOrDefault(p =>p.ID==id);
            if(book==null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        [Authorize]
        public ActionResult Edit(Book book)
        {
            BookManager context = new BookManager();
            Book bookUpdate = context.Books.SingleOrDefault(p => p.ID == book.ID);
            if (bookUpdate != null)
            {
                context.Books.AddOrUpdate(book);
                context.SaveChanges();
            }
            return RedirectToAction("ListBook");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            BookManager context = new BookManager();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [Authorize]
        [HttpPost]
        public ActionResult DeleteBook(int id)
        {
            BookManager context = new BookManager();
            Book book= context.Books.SingleOrDefault(p => p.ID == id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }

            return RedirectToAction("ListBook");
        }
    }
}