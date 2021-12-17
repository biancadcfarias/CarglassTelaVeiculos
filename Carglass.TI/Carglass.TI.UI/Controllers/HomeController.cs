using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carglass.TI.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Página Inicial";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "Sobre";
            return View();
        }


    }
}
