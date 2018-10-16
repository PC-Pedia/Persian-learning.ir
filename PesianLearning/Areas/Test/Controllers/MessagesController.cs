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
    public class MessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/Messages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Messages.ToListAsync());
        }

        // GET: Test/Messages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messages = await _context.Messages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (messages == null)
            {
                return NotFound();
            }

            return View(messages);
        }

        // GET: Test/Messages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/Messages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AdminID,UserID,Title,Text,Read,Date,Ip,IsReplay")] Messages messages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(messages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(messages);
        }

        // GET: Test/Messages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messages = await _context.Messages.FindAsync(id);
            if (messages == null)
            {
                return NotFound();
            }
            return View(messages);
        }

        // POST: Test/Messages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AdminID,UserID,Title,Text,Read,Date,Ip,IsReplay")] Messages messages)
        {
            if (id != messages.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(messages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MessagesExists(messages.ID))
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
            return View(messages);
        }

        // GET: Test/Messages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var messages = await _context.Messages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (messages == null)
            {
                return NotFound();
            }

            return View(messages);
        }

        // POST: Test/Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var messages = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(messages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MessagesExists(int id)
        {
            return _context.Messages.Any(e => e.ID == id);
        }
    }
}
