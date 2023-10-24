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

            new()
            {
                Cinsyet=false,
                Name="ozan",
                Vize1=12,
                Vize2=212
            }


        };


        public IActionResult Index()
        {
            return View(list);
        }
        public IActionResult GetByID(string id)
        {

            var data = list.Where(x => x.Name == id).FirstOrDefault();
            return View(data);
        }
    }
}
