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
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Test/Courses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Courses.Include(c => c.Category).Include(c => c.CourseBefore).Include(c => c.CourseState).Include(c => c.CourseType).Include(c => c.User).Include(c => c.professor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Test/Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.CourseBefore)
                .Include(c => c.CourseState)
                .Include(c => c.CourseType)
                .Include(c => c.User)
                .Include(c => c.professor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Test/Courses/Create
        public IActionResult Create()
        {
            ViewData["CateID"] = new SelectList(_context.Categories, "ID", "Title");
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text");
            ViewData["CourseStateID"] = new SelectList(_context.CourseStates, "ID", "Title");
            ViewData["CourseTypeID"] = new SelectList(_context.CourseTypes, "ID", "Title");
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            ViewData["ProfessorID"] = new SelectList(_context.Professors, "ID", "Evidence");
            return View();
        }

        // POST: Test/Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserID,CateID,ProfessorID,CourseID,CourseTypeID,CourseStateID,TitleFa,TitleEn,Text,StartDate,EndDate,Count,Visit")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CateID"] = new SelectList(_context.Categories, "ID", "Title", course.CateID);
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", course.CourseID);
            ViewData["CourseStateID"] = new SelectList(_context.CourseStates, "ID", "Title", course.CourseStateID);
            ViewData["CourseTypeID"] = new SelectList(_context.CourseTypes, "ID", "Title", course.CourseTypeID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", course.UserID);
            ViewData["ProfessorID"] = new SelectList(_context.Professors, "ID", "Evidence", course.ProfessorID);
            return View(course);
        }

        // GET: Test/Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["CateID"] = new SelectList(_context.Categories, "ID", "Title", course.CateID);
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", course.CourseID);
            ViewData["CourseStateID"] = new SelectList(_context.CourseStates, "ID", "Title", course.CourseStateID);
            ViewData["CourseTypeID"] = new SelectList(_context.CourseTypes, "ID", "Title", course.CourseTypeID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", course.UserID);
            ViewData["ProfessorID"] = new SelectList(_context.Professors, "ID", "Evidence", course.ProfessorID);
            return View(course);
        }

        // POST: Test/Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserID,CateID,ProfessorID,CourseID,CourseTypeID,CourseStateID,TitleFa,TitleEn,Text,StartDate,EndDate,Count,Visit")] Course course)
        {
            if (id != course.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.ID))
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
            ViewData["CateID"] = new SelectList(_context.Categories, "ID", "Title", course.CateID);
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Text", course.CourseID);
            ViewData["CourseStateID"] = new SelectList(_context.CourseStates, "ID", "Title", course.CourseStateID);
            ViewData["CourseTypeID"] = new SelectList(_context.CourseTypes, "ID", "Title", course.CourseTypeID);
            ViewData["UserID"] = new SelectList(_context.ApplicationUsers, "Id", "Id", course.UserID);
            ViewData["ProfessorID"] = new SelectList(_context.Professors, "ID", "Evidence", course.ProfessorID);
            return View(course);
        }

        // GET: Test/Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Category)
                .Include(c => c.CourseBefore)
                .Include(c => c.CourseState)
                .Include(c => c.CourseType)
                .Include(c => c.User)
                .Include(c => c.professor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Test/Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.ID == id);
        }
    }
}
