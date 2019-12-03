using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View(new string[] {"Orange", "Pear" });

        public ViewResult List() => View();

    }
}
