using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WizLib_DataAccess.Data;
using WizLib_Model.Models;

namespace WizLib.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList<Category>();
            return View(categoryList);
        }


        public IActionResult Upsert(int? id)
        {
            var category = new Category();
            if (id != null)
            {
                category = _db.Categories.FirstOrDefault(c => c.Category_Id == id);
                if (category == null)
                {
                    return NotFound();
                }
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Category_Id > 0)
                {
                    _db.Categories.Update(category);
                }
                else
                {
                    _db.Categories.Add(category);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        public IActionResult Delete(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Category_Id == id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }


        public IActionResult CreateMultiple5()
        {
            return CreateMultiple(5);
        }

        public IActionResult CreateMultiple2()
        {
            return CreateMultiple(2);
        }

        public IActionResult CreateMultiple(int nr)
        {
            //for (int i = 0; i < nr; i++)
            //{
            //    _db.Categories.Add(new Category { Name = Guid.NewGuid().ToString() });
            //}
            //_db.SaveChanges();
            //return RedirectToAction(nameof(Index));
            var list = new List<Category>();
            for (int i = 0; i < nr; i++)
            {
                list.Add(new Category { Name = Guid.NewGuid().ToString() });
            }
            _db.AddRange(list);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
