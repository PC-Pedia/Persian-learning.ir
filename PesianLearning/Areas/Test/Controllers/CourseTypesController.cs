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
    public class CourseTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/CourseTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseTypes.ToListAsync());
        }

        // GET: Test/CourseTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseType = await _context.CourseTypes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (courseType == null)
            {
                return NotFound();
            }

            return View(courseType);
        }

        // GET: Test/CourseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/CourseTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title")] CourseType courseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseType);
        }

        // GET: Test/CourseTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseType = await _context.CourseTypes.FindAsync(id);
            if (courseType == null)
            {
                return NotFound();
            }
            return View(courseType);
        }

        // POST: Test/CourseTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title")] CourseType courseType)
        {
            if (id != courseType.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseTypeExists(courseType.ID))
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
            return View(courseType);
        }

        // GET: Test/CourseTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseType = await _context.CourseTypes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (courseType == null)
            {
                return NotFound();
            }

            return View(courseType);
        }

        // POST: Test/CourseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseType = await _context.CourseTypes.FindAsync(id);
            _context.CourseTypes.Remove(courseType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseTypeExists(int id)
        {
            return _context.CourseTypes.Any(e => e.ID == id);
        }
    }
}
