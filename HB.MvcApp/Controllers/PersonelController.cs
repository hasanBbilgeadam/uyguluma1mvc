using HB.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HB.MvcApp.Controllers
{
    public class PersonelController : Controller
    {
        //
        //......./controller ="home"/action="index"



        //....../personel/index
        //....../personel




        List<Personel> Personels = new()
        {

            new(){ID = 1 , Name="a"}, 
            new(){ID = 2 , Name="b"}, 
            new(){ID = 3 , Name="c"}, 
            new(){ID = 4 , Name="d"}, 
            new(){ID = 5 , Name="w"}, 
            new(){ID = 6 , Name="q"}, 
            new(){ID = 7 , Name="e"}, 
        
        
        
        };
        

        public IActionResult Index()
        {

            return View(Personels);
        }


        public IActionResult Index2()
        {
            return View();
        }
    }
}
