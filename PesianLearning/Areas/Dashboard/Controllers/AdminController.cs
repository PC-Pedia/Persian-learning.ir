using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PesianLearning.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View(new ViewModel.VmListOption
            {
                CourseState = new List<ViewModel.VmOption>
                {
                    new ViewModel.VmOption{Title = "mohamad"},
                    new ViewModel.VmOption{Title = "hasan"},
                    new ViewModel.VmOption{Title = "taghi"},
                },
                CourseType = new List<ViewModel.VmOption>
                {
                    new ViewModel.VmOption{Title = "mohamad"},
                    new ViewModel.VmOption{Title = "hasan"},
                    new ViewModel.VmOption{Title = "taghi"},
                }
            });
        }
    }
}