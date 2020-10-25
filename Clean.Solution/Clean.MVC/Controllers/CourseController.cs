using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clean.MVC.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController( ICourseService courseService )
        {
            this._courseService = courseService;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            return View(model);
        }
    }
}
