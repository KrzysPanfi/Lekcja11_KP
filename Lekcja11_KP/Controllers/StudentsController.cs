using Lekcja11_KP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lekcja11_KP.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Listastudentow()
        {
            var list = new List<Student>();
            var st1 = new Student
            {
                Id = 1,
                Name = "Jan",
                Lname = "Kowalski"

            };
            var st2 = new Student
            {
                Id = 2,
                Name = "Jan",
                Lname = "Nowak"
            };
           list.Add(st1);
           list.Add(st2);
            return View(list);
        }

        [HttpPost]
        public IActionResult Add(Student newStudent)
        {
            return RedirectToAction("ListaStudentow");
        }
    }
}
