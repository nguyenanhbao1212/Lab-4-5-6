using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_456.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult create()
        {
            return View();
        }
    }
}