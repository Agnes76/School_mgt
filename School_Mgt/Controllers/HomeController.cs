using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using School_Mgt.Models;
using School_Mgt.Models.ViewModel;
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
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepo;
        private readonly IDepartmentRepository _departmentRepo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IStudentRepository studentRepo, IDepartmentRepository departmentRepo)
        {
            _logger = logger;
            _studentRepo = studentRepo;
            _departmentRepo = departmentRepo;
        }

        public IActionResult Index(bool IsSuccessful )
        {
            if (IsSuccessful)
            {
                ViewBag.IsSuccessful = "Yes";
            }
            var students = _studentRepo.GetAllStudents();
            return View(students);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            var student = _studentRepo.GetStudentById(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var dept = _departmentRepo.GetAllDepts(); 
            ViewBag.Department = new SelectList(dept, "DepartmentId", "DepartmentName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudentViewModel stu)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = new()
                {
                    FirstName = stu.FirstName,
                    LastName = stu.LastName,
                    Address = stu.Address,
                    BirthDate = stu.BirthDate,
                    DepartmentId = stu.DepartmentId,
                    PhoneNumber = stu.PhoneNumber
                };
                _studentRepo.Create(newStudent);

                TempData["SuccessMessage"] = $"Student {newStudent.FirstName} Created Successfully";
                return RedirectToAction("Index", new { IsSuccessful = true});
            }
            return View(stu);
        }

        [HttpGet]    
        public ActionResult Edit(int? id)    
        {    
            if (id == null)    
            {
                return new BadRequestResult();
            }    
            var student = _studentRepo.GetStudentById(id);    
            if (student==null)    
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }    
            return View(student);    
        }  
        
        [HttpPost]    
        [ValidateAntiForgeryToken]    
        public ActionResult Edit(Student student)    
        {    
            if (ModelState.IsValid)
            {
                _studentRepo.Update(student);
                TempData["SuccessMessage"] = "Student " + student.FirstName + " Updated Successfully";
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
            var student = _studentRepo.GetStudentById(id);
            if (student == null)
            {
                Response.StatusCode = 404;
                return View("Not found", id.Value);
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Student student)
        {
            _studentRepo.Delete(student);
            TempData["SuccessMessage"] = $"Student {student.FirstName } Deleted Successfully";
            return RedirectToAction("Index", "Home");   
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
