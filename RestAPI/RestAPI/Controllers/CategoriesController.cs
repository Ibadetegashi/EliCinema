using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
        public class CategoriesController : ControllerBase
        {

            private readonly ApplicationDbContext context;

            public CategoriesController(ApplicationDbContext context)
            {
                this.context = context;
            }
            // GET /api/categories
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Category>>> GetCategorys()
            {
                return await context.Categories.OrderBy(x => x.Name).ToListAsync();
            }

            // GET /api/categorys/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Category>> GetCategory(int id)
            {
                var category = await context.Categories.FindAsync(id);

                if (category == null)
                {
                    return NotFound();
                }

                return category;
            }

            // PUT /api/categorys/5
            [HttpPut("{id}")]
            public async Task<ActionResult<Category>> PutCategory(int id, Category category)
            {
                if (id != category.Id)
                {
                    return BadRequest();
                }

                context.Entry(category).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return NoContent();
            }

            // POST /api/categorys
            [HttpPost]
            public async Task<ActionResult<Category>> PostCategory(Category category)
            {
                context.Categories.Add(category);
                await context.SaveChangesAsync();

                return CreatedAtAction(nameof(PostCategory), category);
            }

            // DELETE /api/categories/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<Category>> DeleteCategory(int id)
            {
                var category = await context.Categories.FindAsync(id);

                context.Categories.Remove(category);
                await context.SaveChangesAsync();

                return NoContent();
            }

        }
    }
    
