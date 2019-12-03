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
        public IActionResult FirstModel()
        {
            _startupConfigurationService.SetModelWorkSystemFirst();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult SecondModel()
        {
            _startupConfigurationService.SetModelWorkSystemSecond();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
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
        public IActionResult FloorsUp()
        {
            _startupConfigurationService.AddFloors();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult FloorsDown()
        {
            _startupConfigurationService.RemoveFloors();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult PeopleUp()
        {
            _startupConfigurationService.AddPeopleInLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult PeopleDown()
        {
            _startupConfigurationService.RemovePeopleInLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult SpeedUp()
        {
            _startupConfigurationService.AddSpeedOfLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult SpeedDown()
        {
            _startupConfigurationService.RemoveSpeedOfLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult AccelerationUp()
        {
            _startupConfigurationService.AddAccelerationOfLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult AccelerationDown()
        {
            _startupConfigurationService.RemoveAccelerationOfLifts();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult ConfigDownload()
        {
            _startupConfigurationService.DownloadConfigurations();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("MenuInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult LiftInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("LiftInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult ExitInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("ExitInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult ResultDownload()
        {
            _startupConfigurationService.DownloadResults();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return RedirectToAction("ExitInterface", startupConfig);
        }
    }
}
