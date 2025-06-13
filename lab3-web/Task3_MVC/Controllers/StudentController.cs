using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Task3_MVC.Models;

namespace Task3_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { Id = 2, Name = "Piotr", Grade = "B" },
                new Student { Id = 1, Name = "Anna", Grade = "A" },
                new Student { Id = 5, Name = "Maria", Grade = "A" },
                new Student { Id = 3, Name = "John", Grade = "C" },
                new Student { Id = 7, Name = "Sarah", Grade = "B" },
                new Student { Id = 4, Name = "David", Grade = "A" },
                new Student { Id = 6, Name = "Emma", Grade = "B" }
            };

            students.Sort((a, b) => a.Id.CompareTo(b.Id));

            return View(students);
        }
    }
}