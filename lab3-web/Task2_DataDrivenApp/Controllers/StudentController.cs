using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task2_DataDrivenApp.Models;

namespace Task2_DataDrivenApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Anna", Grade = "A" },
                new Student { Id = 2, Name = "Piotr", Grade = "B" }
            };
            return View(students);
        }
    }
}