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
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepo;
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger, ITeacherRepository teacherRepo)
        {
            _logger = logger;
            _teacherRepo = teacherRepo;
        }

        public IActionResult Index()
        {
            var teacher = _teacherRepo.GetAllTeachers();
            return View(teacher);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            var teacher = _teacherRepo.GetTeacherById(id);
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherRepo.Create(teacher);
                return RedirectToAction("Details", "Teacher");
            }
            return View();
        }

        [HttpPut]
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            var teacher = _teacherRepo.GetTeacherById(id);
            if (teacher == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            return View(teacher);
        }

        [HttpDelete]
        public IActionResult DeleteConfirmed(int? id)
        {
            var teacher = _teacherRepo.GetTeacherById(id);
            _teacherRepo.Delete(teacher);
            return RedirectToAction("Index", "Home");
        }

    }
}

