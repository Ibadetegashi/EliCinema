using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CinemaApplication.Data;
using CinemaApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CinemaApplication.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public MoviesController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        // GET /admin/movies
        public async Task<IActionResult> Index(int p = 1)
        {
            int pageSize = 6;
            var movies = context.Movies.OrderByDescending(x => x.Id)
                                            .Include(x => x.Category)
                                            .Skip((p - 1) * pageSize)
                                            .Take(pageSize);

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)context.Movies.Count() / pageSize);

            return View(await movies.ToListAsync());
        }

        // GET /admin/movies/details/5
        public async Task<IActionResult> Details(int id)
        {
            Movie movie = await context.Movies.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET /admin/movies/create
        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(context.Categories.OrderBy(x => x.Sorting), "Id", "Name");

            return View();
        }

        // POST /admin/movies/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            ViewBag.CategoryId = new SelectList(context.Categories.OrderBy(x => x.Sorting), "Id", "Name");

            if (ModelState.IsValid)
            {
                movie.Slug = movie.Name.ToLower().Replace(" ", "-");

                var slug = await context.Movies.FirstOrDefaultAsync(x => x.Slug == movie.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The movie already exists.");
                    return View(movie);
                }

                string imageName = "noimage.png";
                if (movie.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(webHostEnvironment.WebRootPath, "media/movies");
                    imageName = Guid.NewGuid().ToString() + "_" + movie.ImageUpload.FileName;
                    string filePath = Path.Combine(uploadsDir, imageName);
                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await movie.ImageUpload.CopyToAsync(fs);
                    fs.Close();
                }

                movie.Image = imageName;

                context.Add(movie);
                await context.SaveChangesAsync();

                TempData["Success"] = "The movie has been added!";

                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET /admin/movies/edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Movie movie = await context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            ViewBag.CategoryId = new SelectList(context.Categories.OrderBy(x => x.Sorting), "Id", "Name", movie.CategoryId);

            return View(movie);
        }

        // POST /admin/movies/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Movie movie)
        {
            ViewBag.CategoryId = new SelectList(context.Categories.OrderBy(x => x.Sorting), "Id", "Name", movie.CategoryId);

            if (ModelState.IsValid)
            {
                movie.Slug = movie.Name.ToLower().Replace(" ", "-");

                var slug = await context.Movies.Where(x => x.Id != id).FirstOrDefaultAsync(x => x.Slug == movie.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The movie already exists.");
                    return View(movie);
                }

                if (movie.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(webHostEnvironment.WebRootPath, "media/movies");

                    if (!string.Equals(movie.Image, "noimage.png"))
                    {
                        string oldImagePath = Path.Combine(uploadsDir, movie.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    string imageName = Guid.NewGuid().ToString() + "_" + movie.ImageUpload.FileName;
                    string filePath = Path.Combine(uploadsDir, imageName);
                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await movie.ImageUpload.CopyToAsync(fs);
                    fs.Close();
                    movie.Image = imageName;
                }

                context.Update(movie);
                await context.SaveChangesAsync();

                TempData["Success"] = "The movie has been edited!";

                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET /admin/movies/delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Movie movie = await context.Movies.FindAsync(id);

            if (movie == null)
            {
                TempData["Error"] = "The movie does not exist!";
            }
            else
            {
                if (!string.Equals(movie.Image, "noimage.png"))
                {
                    string uploadsDir = Path.Combine(webHostEnvironment.WebRootPath, "media/movies");
                    string oldImagePath = Path.Combine(uploadsDir, movie.Image);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                context.Movies.Remove(movie);
                await context.SaveChangesAsync();

                TempData["Success"] = "The movie has been deleted!";
            }

            return RedirectToAction("Index");
        }
    }
}