using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        private List<string> mainList = new List<string> { "Orange", "Pear","Banana" };
        public HomeController(List<string> list = null)
        {
            //mainList = list;
        }

        //public ViewResult Index() => View(new string[] {"Orange", "Pear" });
        public ViewResult Index() => View(mainList);

        public ViewResult List() => View();

    }
}
