using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnetapp.Models;

namespace aspnetapp.Controllers {
    
    public class StudentController : Controller {

        static Student studentCurr = new Student() {
            studentID = 0,
            studentName = "",
            studentAge = 0
        };
        
        public IActionResult Index() {
            ViewBag.Student = studentCurr;
            return View(ViewBag.Student);
        }

        public IActionResult Create() {
            ViewBag.Student = studentCurr;
            return View(ViewBag.Student);
        }

        public IActionResult Exit() {
            
            studentCurr = new Student();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Student std) {
            
            studentCurr = std;
            return RedirectToAction("Index");
        }
    }
}