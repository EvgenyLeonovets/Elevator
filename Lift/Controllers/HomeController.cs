using Lift.Services;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lift.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStartupConfigurationService _startupConfigurationService;

        private readonly StartupConfigurations _startupConfig;
        public HomeController(IStartupConfigurationService startupConfigurationService)
        {
            _startupConfigurationService = startupConfigurationService;
            _startupConfig = _startupConfigurationService.GetStartupConfigurations();

        }

        public IActionResult MenuInterface()
        {
            return View("MenuInterface", _startupConfig);
        }

        public IActionResult MenuInterfaceWithHuman(int floorNumber)
        {
            Random random = new Random();
            //Thread.Sleep(3000);
            ViewBag.ChoisenFloor = random.Next(1, _startupConfig.Floors+1);
            ViewBag.ActiveFloor = floorNumber;
            return View("LiftInterface", _startupConfig);
        }


        [HttpPost]
        public IActionResult FirstModel()
        {
            _startupConfigurationService.SetModelWorkSystemFirst();
            return RedirectToAction("MenuInterface", _startupConfig);
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
        public IActionResult ConfigUpload()
        {
            _startupConfigurationService.UploadConfigurations();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("MenuInterface", startupConfig);
        }


        public IActionResult LiftInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("LiftInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult ResultDownload()
        {
            _startupConfigurationService.DownloadResults();
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("ExitInterface", startupConfig);
        }

        [HttpPost]
        public IActionResult ExitInterface()
        {
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            return View("ExitInterface", startupConfig);
        }
    }
}
