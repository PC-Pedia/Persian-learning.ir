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
    public class GroupShopingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroupShopingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/GroupShopings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.groupShopings.Include(g => g.Course).Include(g => g.Order);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/GroupShopings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupShoping = await _context.groupShopings
                .Include(g => g.Course)
                .Include(g => g.Order)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (groupShoping == null)
            {
                return NotFound();
            }

            return View(groupShoping);
        }

        // GET: Test/GroupShopings/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text");
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "ID");
            return View();
        }

        // POST: Test/GroupShopings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CourseID,OrderID")] GroupShoping groupShoping)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupShoping);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", groupShoping.CourseID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "ID", groupShoping.OrderID);
            return View(groupShoping);
        }

        // GET: Test/GroupShopings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupShoping = await _context.groupShopings.FindAsync(id);
            if (groupShoping == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", groupShoping.CourseID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "ID", groupShoping.OrderID);
            return View(groupShoping);
        }

        // POST: Test/GroupShopings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CourseID,OrderID")] GroupShoping groupShoping)
        {
            if (id != groupShoping.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupShoping);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupShopingExists(groupShoping.ID))
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", groupShoping.CourseID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "ID", "ID", groupShoping.OrderID);
            return View(groupShoping);
        }

        // GET: Test/GroupShopings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupShoping = await _context.groupShopings
                .Include(g => g.Course)
                .Include(g => g.Order)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (groupShoping == null)
            {
                return NotFound();
            }

            return View(groupShoping);
        }

        // POST: Test/GroupShopings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupShoping = await _context.groupShopings.FindAsync(id);
            _context.groupShopings.Remove(groupShoping);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupShopingExists(int id)
        {
            return _context.groupShopings.Any(e => e.ID == id);
        }
    }
}
