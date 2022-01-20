using CinemaApplication.Data;
using CinemaApplication.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaApplication.Models;

using Microsoft.AspNetCore.Authorization;
using CinemaApplication.Data.Static;
using Microsoft.EntityFrameworkCore;

namespace CinemaApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UserRoles.Both)]

    public class ActorsController : Controller
    {
        private readonly IActorsService service;
        private readonly ApplicationDbContext context;

        public ActorsController(IActorsService service, ApplicationDbContext context)
        {
            this.service = service;
            this.context = context;
        }


        public async Task<IActionResult> Index()
        {

            var data = await service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

           await  service.AddAsync(actor);
            TempData["Success"]=actor.FullName+ " was added";
            return RedirectToAction(nameof(Index));
        }
        //GET Actors/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var details = await service.GetByIdAsync(id);

            if (details == null) return View("NotFound");
            return View(details);
        }
        public async Task< IActionResult> Edit(int id)
        {
            var details = await service.GetByIdAsync(id);

            if (details == null) return View("NotFound");
            return View(details);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }
        ////Delete
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var details = await service.GetByIdAsync(id);

        //    if (details == null) return View("NotFound");
        //    return View(details);
        //}
        //[HttpPost,ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var actorD = await service.GetByIdAsync(id);
        //    var movies = context.ShoppingCartItems.Where(n => n.Movie.Id == id).Count();
        //    if (movies != 0)
        //    {
        //        TempData["Error"] = actorD.FullName + " can not be deleted cause there are movies in shopping cart with " + actorD.FullName;
        //    }

        //    if (actorD == null) return View("NotFound");
        //    await service.DeleteAsync(id);
        //    return RedirectToAction(nameof(Index));

        //}
        public async Task<IActionResult> Delete(int id)
        {
            Actor actor = await context.Actors.FindAsync(id);
            var movie = await context.Actors_Movies.Where(n => n.ActorId == id).ToListAsync();

            if (actor == null)
            {
                TempData["Error"] = "The Actor does not exist!";
            }
            else if (movie.Count != 0)
            {
                TempData["Error"] = "Can not delete this actor, cause there are movies with this actor!";
            }
            else
            {
                context.Actors.Remove(actor);
                await context.SaveChangesAsync();

                TempData["Success"] = "The actor has been deleted!";
            }
               if (actor == null) return View("NotFound");


            return RedirectToAction("Index");
        }


    }
}
