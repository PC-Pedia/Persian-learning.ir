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
    public class CourseStatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseStatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CourseStates
        [HttpGet]
        public IEnumerable<CourseState> GetCourseStates()
        {
            return _context.CourseStates;
        }

        // GET: api/CourseStates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseState([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseState = await _context.CourseStates.FindAsync(id);

            if (courseState == null)
            {
                return NotFound();
            }

            return Ok(courseState);
        }

        // PUT: api/CourseStates/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseState([FromRoute] int id, [FromBody] CourseState courseState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseState.ID)
            {
                return BadRequest();
            }

            _context.Entry(courseState).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseStateExists(id))
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

        // POST: api/CourseStates
        [HttpPost]
        public async Task<IActionResult> PostCourseState([FromBody] CourseState courseState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CourseStates.Add(courseState);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourseState", new { id = courseState.ID }, courseState);
        }

        // DELETE: api/CourseStates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseState([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseState = await _context.CourseStates.FindAsync(id);
            if (courseState == null)
            {
                return NotFound();
            }

            _context.CourseStates.Remove(courseState);
            await _context.SaveChangesAsync();

            return Ok(courseState);
        }

        private bool CourseStateExists(int id)
        {
            return _context.CourseStates.Any(e => e.ID == id);
        }
    }
}