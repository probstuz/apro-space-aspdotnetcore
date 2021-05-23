using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using first.Models;

namespace first.Controllers
{
    public class pController : Controller
    {
        private readonly ILogger<pController> _logger;

        public pController(ILogger<pController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Coding()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }

        public IActionResult Addons()
        {
            return View();
        }

        public IActionResult Unity()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
