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
    public class HedingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HedingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/Hedings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Hedings.Include(h => h.Topic);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/Hedings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heding = await _context.Hedings
                .Include(h => h.Topic)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (heding == null)
            {
                return NotFound();
            }

            return View(heding);
        }

        // GET: Test/Hedings/Create
        public IActionResult Create()
        {
            ViewData["TopicID"] = new SelectList(_context.Topics, "ID", "Title");
            return View();
        }

        // POST: Test/Hedings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TopicID,Title,Time")] Heding heding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TopicID"] = new SelectList(_context.Topics, "ID", "Title", heding.TopicID);
            return View(heding);
        }

        // GET: Test/Hedings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heding = await _context.Hedings.FindAsync(id);
            if (heding == null)
            {
                return NotFound();
            }
            ViewData["TopicID"] = new SelectList(_context.Topics, "ID", "Title", heding.TopicID);
            return View(heding);
        }

        // POST: Test/Hedings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TopicID,Title,Time")] Heding heding)
        {
            if (id != heding.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HedingExists(heding.ID))
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
            ViewData["TopicID"] = new SelectList(_context.Topics, "ID", "Title", heding.TopicID);
            return View(heding);
        }

        // GET: Test/Hedings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heding = await _context.Hedings
                .Include(h => h.Topic)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (heding == null)
            {
                return NotFound();
            }

            return View(heding);
        }

        // POST: Test/Hedings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var heding = await _context.Hedings.FindAsync(id);
            _context.Hedings.Remove(heding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HedingExists(int id)
        {
            return _context.Hedings.Any(e => e.ID == id);
        }
    }
}
