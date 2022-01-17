using CinemaApplication.Data;
using CinemaApplication.Areas.Admin.Services;

using CinemaApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaApplication.Data.Static;

namespace CinemaApplication.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UserRoles.Both)]

    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        private readonly ApplicationDbContext context;


        public ProducersController(IProducersService service , ApplicationDbContext context)
        {
            _service = service;
            this.context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //GET: producers/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        //GET: producers/delete/1
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var producerDetails = await _service.GetByIdAsync(id);
        //    if (producerDetails == null) return View("NotFound");
        //    return View(producerDetails);
        //}

        //[HttpPost, ActionName("Delete")]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var producerDetails = await _service.GetByIdAsync(id);
        //    var movie = await context.Movies.Where(n => n.Producer.Id == id).ToListAsync();

        //    if (movie.Count != 0)
        //    {
        //        TempData["Error"] = producerDetails.FullName + " can not be deleted cause there are movies with " + producerDetails.FullName;
        //    }
        //    if (producerDetails == null) return View("NotFound");

        //    await _service.DeleteAsync(id);
        //    return RedirectToAction(nameof(Index));
        //}
        public async Task<IActionResult> Delete(int id)
        {
            Producer pro = await context.Producers.FindAsync(id);
            var movie = await context.Movies.Where(n => n.ProducerId == id).ToListAsync();

            if (pro == null)
            {
                TempData["Error"] = "The Producer does not exist!";
            }
            else if (movie.Count != 0)
            {
                TempData["Error"] = "Can not delete this producer, cause there are movies with this producer!";
            }
            else
            {
                context.Producers.Remove(pro);
                await context.SaveChangesAsync();

                TempData["Success"] = "The producer has been deleted!";
            }

            return RedirectToAction("Index");
        }
    }
}