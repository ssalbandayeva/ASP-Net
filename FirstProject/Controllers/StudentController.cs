using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            List<Student> students = new()
            {
                new Student{Id=1,Name="Mehemmed",Age=27},
                new Student{Id=2,Name="Shahin",Age=18},
                new Student{Id=3,Name="Huseyn",Age=21},
                new Student{Id=4,Name="Orxan",Age=26},
                new Student{Id=5,Name="Semra",Age=32}
            };

            
            //return View();
            return View(students);
            
        }
                
        //public IActionResult Detail(int? id)
        //{
        //    return View(id);
        //}

        public IActionResult Detail(int? id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
