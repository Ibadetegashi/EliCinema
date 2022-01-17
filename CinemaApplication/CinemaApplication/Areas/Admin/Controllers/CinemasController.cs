using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using CinemaApplication.Models;
using CinemaApplication.Areas.Admin.Services;
using CinemaApplication.Data.Static;
using CinemaApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace CinemaApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UserRoles.Both)]

    public class CinemasController : Controller
    {
        private readonly ICinemasService service;
        private readonly ApplicationDbContext context;


        public CinemasController(ICinemasService service, ApplicationDbContext context)
        {
            this.service = service;
            this.context = context;
        }

        
        public async Task<IActionResult> Index()
        {
           
            var data = await service.GetAllAsync();
            return View(data);
        }


        //Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await service.AddAsync(cinema);
            TempData["Success"] = "The Cinema was added!";

            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        //Get: Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        ////Get: Cinemas/Delete/1
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var cinemaDetails = await service.GetByIdAsync(id);
        //    if (cinemaDetails == null) return View("NotFound");
        //    return View(cinemaDetails);
        //}

        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirm(int id)
        //{
        //    var cinemaDetails = await service.GetByIdAsync(id);
        //    if (cinemaDetails == null) return View("NotFound");

        //    await service.DeleteAsync(id);
        //    return RedirectToAction(nameof(Index));
        //}
        public async Task<IActionResult> Delete(int id)
        {
            Cinema pro = await context.Cinemas.FindAsync(id);
            var movie = await context.Movies.Where(n => n.CinemaId == id).ToListAsync();

            if (pro == null)
            {
                TempData["Error"] = "The Cinema does not exist!";
            }
            else if (movie.Count != 0)
            {
                TempData["Error"] = "Can not delete this cinema, cause there are movies in this cinema!";
            }
            else
            {
                context.Cinemas.Remove(pro);
                await context.SaveChangesAsync();

                TempData["Success"] = "The cinema has been deleted!";
            }

            return RedirectToAction("Index");
        }
    }
}
