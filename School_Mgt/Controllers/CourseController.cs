using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School_Mgt.Models;
using School_Mgt.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepo;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger, ICourseRepository courseRepo)
        {
            _logger = logger;
            _courseRepo = courseRepo;
        }

        public IActionResult Index()
        {
            var course = _courseRepo.GetAllCourses();
            return View(course);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            var course = _courseRepo.GetCourseById(id);
            return View(course);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Course course)
        {
            if (ModelState.IsValid)
            {
                _courseRepo.Create(course);
                return RedirectToAction("Index", "Course");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            var course = _courseRepo.GetCourseById(id);
            if (course == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                _courseRepo.Update(course);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            var course = _courseRepo.GetCourseById(id);
            if (course == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            return View(course);
        }

        [HttpDelete]
        public IActionResult DeleteConfirmed(Course course)
        {
            _courseRepo.Delete(course);
            return RedirectToAction("Index", "Home");
        }

    }
}
