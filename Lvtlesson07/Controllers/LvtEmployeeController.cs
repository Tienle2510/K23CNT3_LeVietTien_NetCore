using Lvtlesson07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lvtlesson07.Controllers
{
    public class LvtEmployeeController : Controller
    {
        //Mock Data:
        private static List<LvtEmployee> lvtListEmployee = new List<LvtEmployee>()
        {
            new LvtEmployee
            {
                LvtId = 1,
                LvtName = "Lê Viết Tiến ",
                LvtBirthDay = new DateTime(2005 , 10, 25),
                LvtEmail = "25102005tienle@gmail.com.com",
                LvtPhone = "0965623856",
                LvtSalary = 15000000,
                LvtStatus = true
            },
            new LvtEmployee
            {
                LvtId = 2,
                LvtName = "Trần Thị B",
                LvtBirthDay = new DateTime(2004 , 4 , 16 ),
                LvtEmail = "tranthib@example.com",
                LvtPhone = "0912345678",
                LvtSalary = 18000000,
                LvtStatus = true
            },
            new LvtEmployee
            {
                LvtId = 3,
                LvtName = "Lê Văn C",
                LvtBirthDay = new DateTime(2005 , 12, 10),
                LvtEmail = "levanc@example.com",
                LvtPhone = "0934567890",
                LvtSalary = 12000000,
                LvtStatus = false
            },
            new LvtEmployee
            {
                LvtId = 4,
                LvtName = "Phạm Thị D",
                LvtBirthDay = new DateTime(2003 , 3, 22),
                LvtEmail = "phamthid@example.com",
                LvtPhone = "0978123456",
                LvtSalary = 20000000,
                LvtStatus = true
            },
            new LvtEmployee
            {
                LvtId = 5,
                LvtName = "Hoàng Văn E",
                LvtBirthDay = new DateTime(2004 , 7, 30),
                LvtEmail = "hoangvane@example.com",
                LvtPhone = "0987654321",
                LvtSalary = 22000000,
                LvtStatus = false
            }
        };
        // GET: LvtEmployeeController
        public ActionResult LvtIndex()
        {
            return View();
        }

        // GET: LvtEmployeeController/LvtDetails/5
        public ActionResult LvtDetails(int id)
        {
            var lvtEmployee = lvtListEmployee.FirstOrDefault(x => x.LvtId == id);
            return View(lvtEmployee);
        }

        // GET: LvtEmployeeController/LvtCreate
        public ActionResult LvtCreate()
        {
            var lvtEmployee = new LvtEmployee();
            return View();
        }

        // POST: LvtEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LvtCreate(LvtEmployee lvtModel)
        {
            try
            {
                //Thêm mới nhân viên vào List 
                lvtModel.LvtId = lvtListEmployee.Max(x => x.LvtId) + 1;
                lvtListEmployee.Add(lvtModel);
                return RedirectToAction(nameof(LvtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: LvtEmployeeController/LvtEdit/5
        public ActionResult LvtEdit(int id)
        {
            var lvtEmployee = lvtListEmployee.FirstOrDefault(x=>x.LvtId == id);
            return View();
        }

        // POST: LvtEmployeeController/LvtEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, LvtEmployee lvtModel)
        {
            try
            {
                for (int i = 0; i < lvtListEmployee.Count(); i++)
                {
                    if(lvtListEmployee[i].LvtId == id)
                    {
                        lvtListEmployee[i] = lvtModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(LvtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: LvtEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LvtEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
