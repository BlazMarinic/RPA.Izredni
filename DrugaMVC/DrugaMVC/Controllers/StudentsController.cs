using DrugaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugaMVC.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            var studentList = new List<Student>{
                new Student() { Id = 1, Name = "John", Age = 18 } ,
                new Student() { Id = 2, Name = "Steve", Age = 21 } ,
                new Student() { Id = 3, Name = "Bill", Age = 25 } ,
                new Student() { Id = 4, Name = "Ram" , Age = 20 } ,
                new Student() { Id = 5, Name = "Ron" , Age = 31 } ,
                new Student() { Id = 4, Name = "Chris" , Age = 17 } ,
                new Student() { Id = 4, Name = "Rob" , Age = 19 }
            };
            // Get the students from the database in the real application
            return View(studentList);
        }
    }
}