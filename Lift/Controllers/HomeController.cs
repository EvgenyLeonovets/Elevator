using Lift.Models;
using Lift.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lift.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStartupConfigurationService _startupConfigurationService;
        
        public HomeController(IStartupConfigurationService startupConfigurationService)
        {
            _startupConfigurationService = startupConfigurationService;
        }

        public IActionResult MenuInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult LiftUp()
        {
            _startupConfigurationService.AddLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult LiftDown()
        {
            _startupConfigurationService.RemoveLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult LiftInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("LiftInterface", startupConfig);
        }

        public IActionResult ExitInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("ExitInterface", startupConfig);
        }
    }
}
