using LvtLab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace LvtLab06.Controllers
{
    public class LvtEmployeeController : Controller
    {
        private static List<LvtEmployee> lvtEmployees = new List<LvtEmployee>()
        {
            new LvtEmployee
            {
                LvtId = 1,
                LvtName = "Lê Viết Tiến ",
                LvtBirthday = new DateTime(2005 , 10, 25),
                LvtEmail = "25102005tienle@gmail.com.com",
                LvtPhone = "0965623856",
                LvtSalary = 15000000,
                LvtStatus = true
            },
            new LvtEmployee
            {
                LvtId = 2,
                LvtName = "Trần Thị B",
                LvtBirthday = new DateTime(2004 , 4 , 16 ),
                LvtEmail = "tranthib@example.com",
                LvtPhone = "0912345678",
                LvtSalary = 18000000,
                LvtStatus = true
            },
            new LvtEmployee
            {
                LvtId = 3,
                LvtName = "Lê Văn C",
                LvtBirthday = new DateTime(2005 , 12, 10),
                LvtEmail = "levanc@example.com",
                LvtPhone = "0934567890",
                LvtSalary = 12000000,
                LvtStatus = false
            },
            new LvtEmployee
            {
                LvtId = 4,
                LvtName = "Phạm Thị D",
                LvtBirthday = new DateTime(2003 , 3, 22),
                LvtEmail = "phamthid@example.com",
                LvtPhone = "0978123456",
                LvtSalary = 20000000,
                LvtStatus = true
            },
            new LvtEmployee
            {
                LvtId = 5,
                LvtName = "Hoàng Văn E",
                LvtBirthday = new DateTime(2004 , 7, 30),
                LvtEmail = "hoangvane@example.com",
                LvtPhone = "0987654321",
                LvtSalary = 22000000,
                LvtStatus = false
            }
        };

        public ActionResult LvtIndex()
        {
            return View(lvtEmployees);
        }

        public ActionResult LvtCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LvtCreate(LvtEmployee model)
        {
            if (ModelState.IsValid)
            {
                int newId = lvtEmployees.Any() ? lvtEmployees.Max(e => e.LvtId) + 1 : 1;
                model.LvtId = newId;
                lvtEmployees.Add(model);
                return RedirectToAction("LvtIndex");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult LvtEdit(int id)
        {
            var lvtEmp = lvtEmployees.FirstOrDefault(e => e.LvtId == id);
            return View(lvtEmp);
        }

        [HttpPost]
        public IActionResult LvtEditPUT(LvtEmployee updatedEmp)
        {
            var lvtEmp = lvtEmployees.FirstOrDefault(e => e.LvtId == updatedEmp.LvtId);
            if (lvtEmp != null)
            {
                lvtEmp.LvtName = updatedEmp.LvtName;
                lvtEmp.LvtBirthday = updatedEmp.LvtBirthday;
                lvtEmp.LvtEmail = updatedEmp.LvtEmail;
                lvtEmp.LvtPhone = updatedEmp.LvtPhone;
                lvtEmp.LvtSalary = updatedEmp.LvtSalary;
                lvtEmp.LvtStatus = updatedEmp.LvtStatus;
            }
            return RedirectToAction("LvtIndex");
        }

        public IActionResult LvtDelete(int id)
        {
            var lvtEmp = lvtEmployees.FirstOrDefault(e => e.LvtId == id);
            if (lvtEmp != null) lvtEmployees.Remove(lvtEmp);
            return RedirectToAction("LvtIndex");
        }
    }
}
