using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lift.Controllers
{
    public class HumanController : Controller
    {
        public IActionResult Create(int floorNumber)
        {
            return RedirectToAction("MenuInterfaceWithHuman", "Home", new {floorNumber});
        }

        
    }
}