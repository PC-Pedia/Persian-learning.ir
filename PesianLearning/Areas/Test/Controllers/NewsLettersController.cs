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
    public class NewsLettersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewsLettersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/NewsLetters
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.NewsLetters.Include(n => n.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/NewsLetters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsLetter = await _context.NewsLetters
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newsLetter == null)
            {
                return NotFound();
            }

            return View(newsLetter);
        }

        // GET: Test/NewsLetters/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Test/NewsLetters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,Email")] NewsLetter newsLetter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsLetter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", newsLetter.UserID);
            return View(newsLetter);
        }

        // GET: Test/NewsLetters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsLetter = await _context.NewsLetters.FindAsync(id);
            if (newsLetter == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", newsLetter.UserID);
            return View(newsLetter);
        }

        // POST: Test/NewsLetters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,Email")] NewsLetter newsLetter)
        {
            if (id != newsLetter.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsLetter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsLetterExists(newsLetter.ID))
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
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", newsLetter.UserID);
            return View(newsLetter);
        }

        // GET: Test/NewsLetters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsLetter = await _context.NewsLetters
                .Include(n => n.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newsLetter == null)
            {
                return NotFound();
            }

            return View(newsLetter);
        }

        // POST: Test/NewsLetters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newsLetter = await _context.NewsLetters.FindAsync(id);
            _context.NewsLetters.Remove(newsLetter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsLetterExists(int id)
        {
            return _context.NewsLetters.Any(e => e.ID == id);
        }
    }
}
