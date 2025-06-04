using System.Diagnostics;
using Lvtlesson07.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lvtlesson07.Controllers
{
    public class LvtHomeController : Controller
    {
        private readonly ILogger<LvtHomeController> _logger;

        public LvtHomeController(ILogger<LvtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LvtIndex()
        {
            return View();
        }

        public IActionResult LvtAbout()
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
