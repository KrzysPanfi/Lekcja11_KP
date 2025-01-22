using Lekcja11_KP.Models;
using Microsoft.AspNetCore.Mvc;
namespace Lekcja11_KP.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Listastudentow()
        {
            var dane = new _2019sbdContext().Students.ToList(); 
            return View(dane);
        }

      [HttpPost]
        public IActionResult Add(Student newStudent)
        {
            var context = new _2019sbdContext();
            var StudentId = context.Students.ToList().Count + 1;
            newStudent.IdProduct = StudentId;
            context.Students.Add(newStudent);
            context.SaveChanges();
            return RedirectToAction("Listastudentow");
       }
    }
}
