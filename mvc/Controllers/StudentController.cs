using mvc.Data;
using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index() // Listele
        {
            return View(StudentData.Students);
        }

        public ActionResult New() // Yeni - ekleme
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Student newStudent) // Yeni - ekleme
        {
            StudentData.Students.Add(newStudent);
            return RedirectToAction("Index");

        }
    }
}