using LvtLesson08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LvtLesson08.Controllers
{
    
    public class LvtAccountController : Controller
    {
        private static List<LvtAccount> lvtListAccounts = new List<LvtAccount>()
        {
            new LvtAccount
    {
        LvtId = 103,
        LvtFullName = "Lê Viết Tiến ",
        LvtEmail = "25102005tienle@gmail.com",
        LvtGender = "Nam",
        LvtPassword = "0974922588",
        LvtFacebook = "https://facebook.com/nguyenvanan",
        LvtPhone = "0965623856",
        LvtAddress = "Hà Nội",
        LvtAvatar = "https://i.pravatar.cc/150?img=1",
        LvtBirthday = new DateTime(2005, 10, 25)
    },
    new LvtAccount
    {
        LvtId = 2,
        LvtFullName = "Trần Thị Bình",
        LvtEmail = "binh.tran@yahoo.com",
        LvtGender = "Nữ",
        LvtPassword = "Binh2024$",
        LvtFacebook = "https://facebook.com/tranthibinh",
        LvtPhone = "0912345678",
        LvtAddress = "TP. Hồ Chí Minh",
        LvtAvatar = "https://i.pravatar.cc/150?img=2",
        LvtBirthday = new DateTime(1998, 12, 5)
    },
    new LvtAccount
    {
        LvtId = 3,
        LvtFullName = "Lê Hoàng Cường",
        LvtEmail = "cuong.le@outlook.com",
        LvtGender = "Nam",
        LvtPassword = "Cuong@123",
        LvtFacebook = "https://facebook.com/lehoangcuong",
        LvtPhone = "0933456789",
        LvtAddress = "Đà Nẵng",
        LvtAvatar = "https://i.pravatar.cc/150?img=3",
        LvtBirthday = new DateTime(1994, 6, 15)
    },
    new LvtAccount
    {
        LvtId = 4,
        LvtFullName = "Phạm Thảo Dung",
        LvtEmail = "dung.pham@hotmail.com",
        LvtGender = "Nữ",
        LvtPassword = "Dung456!",
        LvtFacebook = "https://facebook.com/phamthaodung",
        LvtPhone = "0925678901",
        LvtAddress = "Hải Phòng",
        LvtAvatar = "https://i.pravatar.cc/150?img=4",
        LvtBirthday = new DateTime(2000, 9, 30)
    },
    new LvtAccount
    {
        LvtId = 5,
        LvtFullName = "Đỗ Văn Em",
        LvtEmail = "em.do@gmail.com",
        LvtGender = "Nam",
        LvtPassword = "Em2025#",
        LvtFacebook = "https://facebook.com/dovanem",
        LvtPhone = "0976543210",
        LvtAddress = "Cần Thơ",
        LvtAvatar = "https://i.pravatar.cc/150?img=5",
        LvtBirthday = new DateTime(1992, 1, 10)
    }
        };
        // GET: LvtAccountController
        public ActionResult LvtIndex()
        {
            return View(lvtListAccounts);
        }

        // GET: LvtAccountController/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: LvtAccountController/Create
        public ActionResult LvtCreate()
        {
            var lvtModel = new LvtAccount();
            return View();
        }

        // POST: LvtAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LvtAccount lvtModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    lvtListAccounts.Add(lvtModel);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch (Exception ex) 
            {
                ModelState.AddModelError("","Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View();
            }
        }

        // GET: LvtAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LvtAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: LvtAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LvtAccountController/Delete/5
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
