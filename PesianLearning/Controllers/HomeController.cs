using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Persian_Learning.ir.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Course()
        {
            return View();
        }
        public ActionResult HtmlCourse()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }

    }
}