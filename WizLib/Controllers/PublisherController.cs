using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizLib_DataAccess.Data;
using WizLib_Model.Models;

namespace WizLib.Controllers
{
    public class PublisherController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PublisherController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Publisher> categoryList = _db.Publishers.ToList<Publisher>();
            return View(categoryList);
        }


        public IActionResult Upsert(int? id)
        {
            var category = new Publisher();
            if (id != null)
            {
                category = _db.Publishers.FirstOrDefault(c => c.PublisherId == id);
                if (category == null)
                {
                    return NotFound();
                }
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Publisher category)
        {
            if (ModelState.IsValid)
            {
                if (category.PublisherId > 0)
                {
                    _db.Publishers.Update(category);
                }
                else
                {
                    _db.Publishers.Add(category);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        public IActionResult Delete(int id)
        {
            var category = _db.Publishers.FirstOrDefault(c => c.PublisherId == id);
            if (category != null)
            {
                _db.Publishers.Remove(category);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
