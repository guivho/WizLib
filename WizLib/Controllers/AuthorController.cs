using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizLib_DataAccess.Data;
using WizLib_Model.Models;

namespace WizLib.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AuthorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Author> authorList = _db.Authors.ToList<Author>();
            return View(authorList);
        }


        public IActionResult Upsert(int? id)
        {
            var author = new Author();
            if (id != null)
            {
                author = _db.Authors.FirstOrDefault(c => c.AuthorId == id);
                if (author == null)
                {
                    return NotFound();
                }
            }
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Author author)
        {
            if (ModelState.IsValid)
            {
                if (author.AuthorId > 0)
                {
                    _db.Authors.Update(author);
                }
                else
                {
                    _db.Authors.Add(author);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }


        public IActionResult Delete(int id)
        {
            var author = _db.Authors.FirstOrDefault(c => c.AuthorId == id);
            if (author != null)
            {
                _db.Authors.Remove(author);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
