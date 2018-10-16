using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using PesianLearning.Data;

namespace PesianLearning.Areas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CourseTypes
        [HttpGet]
        public IEnumerable<CourseType> GetCourseTypes()
        {
            return _context.CourseTypes;
        }

        // GET: api/CourseTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseType = await _context.CourseTypes.FindAsync(id);

            if (courseType == null)
            {
                return NotFound();
            }

            return Ok(courseType);
        }

        // PUT: api/CourseTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseType([FromRoute] int id, [FromBody] CourseType courseType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseType.ID)
            {
                return BadRequest();
            }

            _context.Entry(courseType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseTypeExists(id))
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

        // POST: api/CourseTypes
        [HttpPost]
        public async Task<IActionResult> PostCourseType([FromBody] CourseType courseType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CourseTypes.Add(courseType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourseType", new { id = courseType.ID }, courseType);
        }

        // DELETE: api/CourseTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseType = await _context.CourseTypes.FindAsync(id);
            if (courseType == null)
            {
                return NotFound();
            }

            _context.CourseTypes.Remove(courseType);
            await _context.SaveChangesAsync();

            return Ok(courseType);
        }

        private bool CourseTypeExists(int id)
        {
            return _context.CourseTypes.Any(e => e.ID == id);
        }
    }
}