using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Myapp.Models.Services.Application;
using Myapp.Models.ViewModels;

namespace Myapp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetServices();
            return View(courses);
        }

        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}