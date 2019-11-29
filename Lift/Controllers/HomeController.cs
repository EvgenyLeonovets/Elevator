using System;
using Microsoft.AspNetCore.Mvc;
using Lift.Models;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Lift.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MenuInterface(StartupConfigurations startupConfigurations)
        {
            ViewBag.Configuration = startupConfigurations;
            return View("MenuInterface", startupConfigurations);
        }

        [HttpPost]
        public IActionResult LiftInterface(StartupConfigurations startupConfigurations)
        {
            return View("LiftInterface", startupConfigurations);
        }

        public IActionResult ExitInterface()
        {
            return View();
        }
    }
}
