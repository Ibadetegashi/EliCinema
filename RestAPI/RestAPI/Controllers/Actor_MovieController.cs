using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Actor_MovieController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Actor_MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Actor_Movie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor_Movie>>> GetActors_Movies()
        {
            return await _context.Actors_Movies.ToListAsync();
        }

        // GET: api/Actor_Movie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Actor_Movie>> GetActor_Movie(int id)
        {
            var actor_Movie = await _context.Actors_Movies.FindAsync(id);

            if (actor_Movie == null)
            {
                return NotFound();
            }

            return actor_Movie;
        }

        // PUT: api/Actor_Movie/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActor_Movie(int id, Actor_Movie actor_Movie)
        {
            if (id != actor_Movie.ActorId)
            {
                return BadRequest();
            }

            _context.Entry(actor_Movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Actor_MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Actor_Movie
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Actor_Movie>> PostActor_Movie(Actor_Movie actor_Movie)
        {
            _context.Actors_Movies.Add(actor_Movie);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Actor_MovieExists(actor_Movie.ActorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActor_Movie", new { id = actor_Movie.ActorId }, actor_Movie);
        }

        // DELETE: api/Actor_Movie/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Actor_Movie>> DeleteActor_Movie(int id)
        {
            var actor_Movie = await _context.Actors_Movies.FindAsync(id);
            if (actor_Movie == null)
            {
                return NotFound();
            }

            _context.Actors_Movies.Remove(actor_Movie);
            await _context.SaveChangesAsync();

            return actor_Movie;
        }

        private bool Actor_MovieExists(int id)
        {
            return _context.Actors_Movies.Any(e => e.ActorId == id);
        }
    }
}
