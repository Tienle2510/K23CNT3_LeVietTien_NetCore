using Lvt_lesson07Model.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lvt_lesson07Model.Controllers
{
    public class LvtMemberController : Controller
    {
        private static List<LvtMember> lvtListMember = new List<LvtMember>()
        {
         new LvtMember
            {
                LvtMemberId = "2310900103",
                LvtUserName = "Le Viet Tien",
                LvtPassword = "12349",
                LvtFullName = "Le Viet Tien",
                LvtEmail = "25102005tienle@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = "M002",
                LvtUserName = "jane_smith",
                LvtPassword = "abcdef",
                LvtFullName = "Jane Smith",
                LvtEmail = "jane@example.com"
            },
            new LvtMember
            {
                LvtMemberId = "M003",
                LvtUserName = "michael_ng",
                LvtPassword = "michael123",
                LvtFullName = "Michael Nguyen",
                LvtEmail = "michael@example.com"
            },
            new LvtMember
            {
                LvtMemberId = "M004",
                LvtUserName = "lisa_ho",
                LvtPassword = "lisa789",
                LvtFullName = "Lisa Ho",
                LvtEmail = "lisa@example.com"
            },
            new LvtMember
            {
                LvtMemberId = "M005",
                LvtUserName = "david_lee",
                LvtPassword = "davidpass",
                LvtFullName = "David Lee",
                LvtEmail = "david@example.com"
            }
        };
        public IActionResult LvtIndex()//List Member
        {
            return View(lvtListMember);
        }
    }
}
