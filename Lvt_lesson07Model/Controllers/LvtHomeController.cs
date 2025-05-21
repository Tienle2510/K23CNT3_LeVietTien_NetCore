using System.Diagnostics;
using Lvt_lesson07Model.Models;
using Lvt_lesson07Model.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lvt_lesson07Model.Controllers
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
            LvtMember lvtMember = new LvtMember();
            lvtMember.LvtMemberId = Guid.NewGuid().ToString();
            lvtMember.LvtUserName = "Viet Tien";
            lvtMember.LvtPassword = "12349";
            lvtMember.LvtFullName = "Le Viet Tien";
            lvtMember.LvtEmail = "25102005tienle@gmail.com";

            return View(lvtMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
