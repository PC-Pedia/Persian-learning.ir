using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using PesianLearning.Data;

namespace PesianLearning.Areas.Test.Controllers
{
    [Area("Test")]
    public class CourseStatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseStatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/CourseStates
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseStates.ToListAsync());
        }

        // GET: Test/CourseStates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseState = await _context.CourseStates
                .FirstOrDefaultAsync(m => m.ID == id);
            if (courseState == null)
            {
                return NotFound();
            }

            return View(courseState);
        }

        // GET: Test/CourseStates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/CourseStates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title")] CourseState courseState)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseState);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseState);
        }

        // GET: Test/CourseStates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseState = await _context.CourseStates.FindAsync(id);
            if (courseState == null)
            {
                return NotFound();
            }
            return View(courseState);
        }

        // POST: Test/CourseStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title")] CourseState courseState)
        {
            if (id != courseState.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseState);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseStateExists(courseState.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(courseState);
        }

        // GET: Test/CourseStates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseState = await _context.CourseStates
                .FirstOrDefaultAsync(m => m.ID == id);
            if (courseState == null)
            {
                return NotFound();
            }

            return View(courseState);
        }

        // POST: Test/CourseStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseState = await _context.CourseStates.FindAsync(id);
            _context.CourseStates.Remove(courseState);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseStateExists(int id)
        {
            return _context.CourseStates.Any(e => e.ID == id);
        }
    }
}
