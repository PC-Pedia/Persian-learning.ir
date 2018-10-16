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
    public class ProfSkillsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfSkillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/ProfSkills
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.profSkills.Include(p => p.Skill).Include(p => p.professor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/ProfSkills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profSkill = await _context.profSkills
                .Include(p => p.Skill)
                .Include(p => p.professor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (profSkill == null)
            {
                return NotFound();
            }

            return View(profSkill);
        }

        // GET: Test/ProfSkills/Create
        public IActionResult Create()
        {
            ViewData["SkillID"] = new SelectList(_context.Skills, "ID", "Title");
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence");
            return View();
        }

        // POST: Test/ProfSkills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProfID,SkillID")] ProfSkill profSkill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profSkill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SkillID"] = new SelectList(_context.Skills, "ID", "Title", profSkill.SkillID);
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence", profSkill.ProfID);
            return View(profSkill);
        }

        // GET: Test/ProfSkills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profSkill = await _context.profSkills.FindAsync(id);
            if (profSkill == null)
            {
                return NotFound();
            }
            ViewData["SkillID"] = new SelectList(_context.Skills, "ID", "Title", profSkill.SkillID);
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence", profSkill.ProfID);
            return View(profSkill);
        }

        // POST: Test/ProfSkills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProfID,SkillID")] ProfSkill profSkill)
        {
            if (id != profSkill.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profSkill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfSkillExists(profSkill.ID))
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
            ViewData["SkillID"] = new SelectList(_context.Skills, "ID", "Title", profSkill.SkillID);
            ViewData["ProfID"] = new SelectList(_context.Professors, "ID", "Evidence", profSkill.ProfID);
            return View(profSkill);
        }

        // GET: Test/ProfSkills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profSkill = await _context.profSkills
                .Include(p => p.Skill)
                .Include(p => p.professor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (profSkill == null)
            {
                return NotFound();
            }

            return View(profSkill);
        }

        // POST: Test/ProfSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profSkill = await _context.profSkills.FindAsync(id);
            _context.profSkills.Remove(profSkill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfSkillExists(int id)
        {
            return _context.profSkills.Any(e => e.ID == id);
        }
    }
}
