using Lift.Services;
using Lift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lift.Controllers
{
    public class LogicLiftsController : Controller
    {
        private readonly IStartupConfigurationService _startupConfigurationService;

        public LogicLiftsController(IStartupConfigurationService startupConfigurationService)
        {
            _startupConfigurationService = startupConfigurationService;
        }

        [HttpPost]
        public async Task<IActionResult> Start()
        {
            //await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            var startupConfig = _startupConfigurationService.GetStartupConfigurations();
            if (startupConfig.ModelWorkSystem == true)
            {

            }
            else
            {

            }
            return View("LiftInterface", startupConfig);
        }
    }
}