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

namespace CinemaApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UserRoles.Admin)]

    public class ActorsController : Controller
    {
        private readonly IActorsService service;
        public ActorsController(IActorsService service)
        {
            this.service = service;
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
        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var details = await service.GetByIdAsync(id);

            if (details == null) return View("NotFound");
            return View(details);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorD = await service.GetByIdAsync(id);
            if (actorD == null) return View("NotFound");
            await service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }

    }
}
