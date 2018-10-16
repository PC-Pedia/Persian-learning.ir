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
    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/Images
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Images.Include(i => i.Category).Include(i => i.Course).Include(i => i.Professor).Include(i => i.Server);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/Images/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Images
                .Include(i => i.Category)
                .Include(i => i.Course)
                .Include(i => i.Professor)
                .Include(i => i.Server)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // GET: Test/Images/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title");
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text");
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence");
            ViewData["ServerID"] = new SelectList(_context.Servers, "ID", "Title");
            return View();
        }

        // POST: Test/Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ServerID,CourseID,CategoryID,ProfID,FileName,Alt")] Image image)
        {
            if (ModelState.IsValid)
            {
                _context.Add(image);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title", image.CategoryID);
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", image.CourseID);
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence", image.ProfID);
            ViewData["ServerID"] = new SelectList(_context.Servers, "ID", "Title", image.ServerID);
            return View(image);
        }

        // GET: Test/Images/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Images.FindAsync(id);
            if (image == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title", image.CategoryID);
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", image.CourseID);
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence", image.ProfID);
            ViewData["ServerID"] = new SelectList(_context.Servers, "ID", "Title", image.ServerID);
            return View(image);
        }

        // POST: Test/Images/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ServerID,CourseID,CategoryID,ProfID,FileName,Alt")] Image image)
        {
            if (id != image.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(image);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageExists(image.ID))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title", image.CategoryID);
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", image.CourseID);
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence", image.ProfID);
            ViewData["ServerID"] = new SelectList(_context.Servers, "ID", "Title", image.ServerID);
            return View(image);
        }

        // GET: Test/Images/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Images
                .Include(i => i.Category)
                .Include(i => i.Course)
                .Include(i => i.Professor)
                .Include(i => i.Server)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        // POST: Test/Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.Images.FindAsync(id);
            _context.Images.Remove(image);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageExists(int id)
        {
            return _context.Images.Any(e => e.ID == id);
        }
    }
}
