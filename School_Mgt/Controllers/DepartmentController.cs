using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using School_Mgt.Models;
using School_Mgt.Models.Models.ViewModel;
using School_Mgt.Repository.Implementation;
using School_Mgt.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace School_Mgt.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(ILogger<DepartmentController> logger, IDepartmentRepository departmentRepo)
        {
            _logger = logger;
            _departmentRepo = departmentRepo;
        }

        public IActionResult Index()
        {
            var dept = _departmentRepo.GetAllDepts();
            return View(dept);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            var dept = _departmentRepo.GetDeptById(id);
            return View(dept);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CreateDepartmentViewModel dept)
        {
            if (ModelState.IsValid)
            {
                Department newDept = new()
                {
                    DepartmentName = dept.DepartmentName,
                    Size = dept.Size
                };
                _departmentRepo.Create(newDept);

                TempData["SuccessMessage"] = $"Student {newDept.DepartmentName} Created Successfully";
                return RedirectToAction("Index", new { IsSuccessful = true });
            }
            return View(dept);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }
            var dept = _departmentRepo.GetDeptById(id);
            if (dept == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            return View(dept);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department dept)
        {
            if (ModelState.IsValid)
            {
                _departmentRepo.Update(dept);
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
            var dept = _departmentRepo.GetDeptById(id);
            if (dept == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            return View(dept);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Department dept)
        {
            _departmentRepo.Delete(dept);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}

