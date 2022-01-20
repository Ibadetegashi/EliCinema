using CinemaApplication.Areas.Admin.Services;
using CinemaApplication.Data;
using CinemaApplication.Data.Static;
using CinemaApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApplication.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Authorize(Roles = UserRoles.Both)]
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        private readonly ApplicationDbContext _context;

        public MoviesController(IMoviesService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n=>n.MovieCategory);
            return View(allMovies);
        }

      
        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
            ViewBag.Categories = new SelectList(movieDropdownsData.Categories, "Id", "Name");

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        //{
        //    if (!ModelState.IsValid) return View(cinema);
        //    await _service.AddAsync(cinema);
        //   return RedirectToAction(nameof(Index));
        //}

        //GET: Movies/Details/1
   
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            if (movieDetail == null) return View("NotFound");

            return View(movieDetail);
        }
        //public async Task<IActionResult> Filter(string searchString)
        //{
        //    var allMovies = await _service.GetAllAsync(n => n.Cinema);

        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

        //        var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

        //        return View("Index", filteredResultNew);
        //    }

        //    return View("Index", allMovies);
        //}

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
                ViewBag.Categories = new SelectList(movieDropdownsData.Categories, "Id", "Name");

                return View(movie);
            }

            await _service.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }


        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("NotFound");

            var response = new NewMovieVM()
            {
                Id = movieDetails.Id,
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                ImageURL = movieDetails.ImageURL,
                MovieCategory = movieDetails.CategoryId,
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
                ActorIds = movieDetails.Actors_Movies.Select(n => n.ActorId).ToList(),
            };

            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
            ViewBag.Categories = new SelectList(movieDropdownsData.Categories, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if (id != movie.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");
                ViewBag.Categories = new SelectList(movieDropdownsData.Categories, "Id", "Name");

                return View(movie);
            }

            await _service.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
        //Delete
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var details = await _service.GetByIdAsync(id);

        //    if (details == null) return View("NotFound");
        //    return View(details);
        //}
        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var actorD = await _service.GetByIdAsync(id);
        //    if (actorD == null) return View("NotFound");
        //    await _service.DeleteAsync(id);
        //    return RedirectToAction(nameof(Index));

        //}
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _service.GetMovieByIdAsync(id);
            var shop = _context.ShoppingCartItems.Where(n => n.Movie.Id == id).ToList();

            var order = _context.OrderItems.Where(n => n.MovieId == id).ToList();

            if (movie == null) return View("NotFound");

            if (movie == null)
            {
                TempData["Error"] = "The movie does not exist!";
            }
            else if (shop != null)
            {
                TempData["Error"] = "The movie exist in shopping cart !";


            }

            else
            {
                await _service.DeleteAsync(id);



                TempData["Success"] = "The movie has been deleted!";
            }

            return RedirectToAction("Index");
        }


    }

}