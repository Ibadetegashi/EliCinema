using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaApplication.Data;
using CinemaApplication.Models;

namespace CinemaApplication.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GenreController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Genre> obj = _db.Genres;
            return View(obj);
        }
        public IActionResult Create()
        {
            return View();
        }
        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre obj)
        {
            _db.Genres.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Genres.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Genres.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Genres.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Update(int? id)
        {
            

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Genres.Find(id);
            if (obj== null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Genre obj)
        {
            if (ModelState.IsValid)
            {
                _db.Genres.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        

    }
}


