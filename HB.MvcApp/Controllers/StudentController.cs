using HB.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HB.MvcApp.Controllers
{
    public class StudentController : Controller
    {

        List<Student> list = new List<Student>()
        {

            new("hasan",50,30,false),
            new("ozan",90,90,false),
            new("burak",20,70,false),
            new("burcu",70,70,true),


        };


        public IActionResult Index()
        {
            return View(list);
        }
    }
}
