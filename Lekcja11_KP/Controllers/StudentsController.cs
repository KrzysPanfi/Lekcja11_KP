﻿using Lekcja11_KP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text.Json;


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
            var dane = new _2019sbdContext().Students.ToList(); 
            return View(dane);
        }

      [HttpPost]
        public IActionResult Add(Student newStudent)
        {
           return RedirectToAction("ListaStudentow");
       }
    }
}
