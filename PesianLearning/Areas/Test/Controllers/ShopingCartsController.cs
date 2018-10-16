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
    public class ShopingCartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopingCartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/ShopingCarts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ShopingCarts.Include(s => s.Course).Include(s => s.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/ShopingCarts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopingCart = await _context.ShopingCarts
                .Include(s => s.Course)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shopingCart == null)
            {
                return NotFound();
            }

            return View(shopingCart);
        }

        // GET: Test/ShopingCarts/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text");
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Test/ShopingCarts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,CourseID,Date")] ShopingCart shopingCart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopingCart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", shopingCart.CourseID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", shopingCart.UserID);
            return View(shopingCart);
        }

        // GET: Test/ShopingCarts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopingCart = await _context.ShopingCarts.FindAsync(id);
            if (shopingCart == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", shopingCart.CourseID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", shopingCart.UserID);
            return View(shopingCart);
        }

        // POST: Test/ShopingCarts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,CourseID,Date")] ShopingCart shopingCart)
        {
            if (id != shopingCart.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopingCart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopingCartExists(shopingCart.ID))
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
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", shopingCart.CourseID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", shopingCart.UserID);
            return View(shopingCart);
        }

        // GET: Test/ShopingCarts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopingCart = await _context.ShopingCarts
                .Include(s => s.Course)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shopingCart == null)
            {
                return NotFound();
            }

            return View(shopingCart);
        }

        // POST: Test/ShopingCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopingCart = await _context.ShopingCarts.FindAsync(id);
            _context.ShopingCarts.Remove(shopingCart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopingCartExists(int id)
        {
            return _context.ShopingCarts.Any(e => e.ID == id);
        }
    }
}
