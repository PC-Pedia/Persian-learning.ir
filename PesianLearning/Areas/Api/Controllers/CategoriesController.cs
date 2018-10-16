using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using PesianLearning.Data;
using ViewModel;

namespace PesianLearning.Areas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public IEnumerable<VmOption> GetCategories()
        {
            List<VmOption> ListCategory = _context.Categories.Include(c => c.Image).ThenInclude(i => i.Server)
                .Select(category => new VmOption
                {
                    ID = category.ID,
                    Title = category.Title,
                    Url = category.Image.Server.Url.TrimEnd('/') + "/" + category.Image.FileName
                }).ToList();
            return ListCategory;
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public IActionResult GetCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = _context.Categories.Where(m => m.ID == id).Include(m => m.Image).ThenInclude(i => i.Server).FirstOrDefault();


            if (category == null)
            {
                return NotFound();
            }


            return Ok(new VmOption
            {
                ID = category.ID,
                Title = category.Title,
                Url = category.Image.Server.Url.TrimEnd('/') + "/" + category.Image.FileName
            });
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory([FromRoute] int id, [FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != category.ID)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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

        // POST: api/Categories
        [HttpPost]
        public async Task<IActionResult> PostCategory([FromBody] VmOption category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Categories.Add(new Category
            {
                ID = category.ID,
                Title = category.Title,
            });
            await _context.SaveChangesAsync();
            //string UserID = (User.Identity.IsAuthenticated ? User.Identity.Name : null);
            _context.Images.Add(new Image
            {
                Alt = category.Title,
                ServerID = _context.Servers.Where(m => m.Title == "دسته بندی ها").FirstOrDefault().ID,
                FileName = category.Url,
                CategoryID = category.ID
            });
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.ID }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = await _context.Categories.FindAsync(id);
            var image =  _context.Images.Where(m=>m.CourseID == id).FirstOrDefault();
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.Images.Remove(image);

            await _context.SaveChangesAsync();

            return Ok(category);
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.ID == id);
        }
    }
}