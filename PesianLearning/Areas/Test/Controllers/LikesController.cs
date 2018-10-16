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
    public class LikesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LikesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/Likes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Likes.Include(l => l.Course).Include(l => l.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/Likes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var like = await _context.Likes
                .Include(l => l.Course)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (like == null)
            {
                return NotFound();
            }

            return View(like);
        }

        // GET: Test/Likes/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text");
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Test/Likes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,CourseID")] Like like)
        {
            if (ModelState.IsValid)
            {
                _context.Add(like);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", like.CourseID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", like.UserID);
            return View(like);
        }

        // GET: Test/Likes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var like = await _context.Likes.FindAsync(id);
            if (like == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", like.CourseID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", like.UserID);
            return View(like);
        }

        // POST: Test/Likes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,CourseID")] Like like)
        {
            if (id != like.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(like);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LikeExists(like.ID))
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", like.CourseID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", like.UserID);
            return View(like);
        }

        // GET: Test/Likes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var like = await _context.Likes
                .Include(l => l.Course)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (like == null)
            {
                return NotFound();
            }

            return View(like);
        }

        // POST: Test/Likes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var like = await _context.Likes.FindAsync(id);
            _context.Likes.Remove(like);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LikeExists(int id)
        {
            return _context.Likes.Any(e => e.ID == id);
        }
    }
}
