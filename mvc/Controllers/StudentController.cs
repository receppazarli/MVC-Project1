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

        public ActionResult Edit(int id) // Düzenle - Güncelleme
        {
            var student = StudentData.Students.Where(o => o.Id == id).FirstOrDefault();
            return View(student);
        }


        [HttpPost]
        public ActionResult Edit(Student newStudent) // Düzenle - Güncelleme
        {
            Student editStudent = StudentData.Students.Where(o => o.Id == newStudent.Id).FirstOrDefault();
            editStudent.Name = newStudent.Name;
            editStudent.DepartmentName = newStudent.DepartmentName;
            editStudent.EntryYear = newStudent.EntryYear;
            editStudent.Surname = newStudent.Surname;
            editStudent.IdentityNumber = newStudent.IdentityNumber;
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id) // Sil 
        {
            var student = StudentData.Students.Where(o => o.Id == id).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student student) // Sil 
        {
            Student DeleteStudent = StudentData.Students.Where(o => o.Id == student.Id).FirstOrDefault();
            StudentData.Students.Remove(DeleteStudent);
            return RedirectToAction("Index");
        }
    }
}