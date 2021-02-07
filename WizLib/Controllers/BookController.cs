using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizLib_DataAccess.Data;
using WizLib_Model.Models;
using WizLib_Model.ViewModel;

namespace WizLib.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Book> bookList = _db.Books.ToList<Book>();
            return View(bookList);
        }


        public IActionResult Upsert(int? id)
        {
            var bookVM = new BookVM
            {
                PublisherList = _db.Publishers.Select(i => new SelectListItem
                {
                    Text = i.PublisherName,
                    Value = i.PublisherId.ToString()
                })
            };
            if (id != null)
            {
                bookVM.Book = _db.Books.FirstOrDefault(c => c.BookId == id);
                if (bookVM == null)
                {
                    return NotFound();
                }
            }
            return View(bookVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Book book)
        {
            if (ModelState.IsValid)
            {
                if (book.BookId > 0)
                {
                    _db.Books.Update(book);
                }
                else
                {
                    _db.Books.Add(book);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }


        public IActionResult Delete(int id)
        {
            var book = _db.Books.FirstOrDefault(c => c.BookId == id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
