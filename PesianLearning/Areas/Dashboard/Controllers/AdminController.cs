using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PesianLearning.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View(new Data.ApplicationDbContext().Courses
                .Include(c=>c.Topics).ThenInclude(m=>m.Heding)
                .Include(c=>c.Images).ThenInclude(m=>m.Server)
                .Include(c => c.Category)
                .Include(c => c.CourseBefore)
                .Include(c => c.CourseState)
                .Include(c => c.CourseType)
                .Include(c => c.professor).ToList());
            //return View(new ViewModel.VmListOption
            //{
            //    CourseState = new List<ViewModel.VmOption>
            //    {
            //        new ViewModel.VmOption{Title = "mohamad"},
            //        new ViewModel.VmOption{Title = "hasan"},
            //        new ViewModel.VmOption{Title = "taghi"},
            //    },
            //    CourseType = new List<ViewModel.VmOption>
            //    {
            //        new ViewModel.VmOption{Title = "mohamad"},
            //        new ViewModel.VmOption{Title = "hasan"},
            //        new ViewModel.VmOption{Title = "taghi"},
            //    }
            //});
        }
        public IActionResult _TopicList(int ID)
        {
            return View(new Data.ApplicationDbContext().Topics.Where(m => m.CourseID == ID).ToList());
        }
    }
}