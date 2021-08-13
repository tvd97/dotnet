using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES3.Data.Access;
using UPES3.Data.LogicLayer;

namespace UPES3.Controllers
{
    [Authorize(Roles ="isAdmin")]
    public class AdminController : Controller
    {
        AdminDLL get = new AdminDLL();
        // GET: Admin
        public ActionResult Index(string seach, int page = 1, int pagesize = 30)
        {
            var model = get.getListAccount(seach, page, pagesize);
            ViewBag.seaching = seach;
            return View(model);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            ViewBag.role = new List<SelectListItem>{
                       new SelectListItem { Value = "isAdmin" , Text = "Admin" },
                       new SelectListItem { Value = "isManage" , Text = "Phòng Nghiên Cứu Khoa Học" },
                        new SelectListItem { Value = "isUser" , Text = "Giảng Viên" },
                         new SelectListItem { Value = "isStudent" , Text = "Sinh Viên" }
            };
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(account model)
        {
            model.status = 1;
            try
            {
                get.addAccount(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
           
                 
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            if(id==null)
            {
                return RedirectToAction("index");
            } 
            
            var model = get.getDetail(id);
            ViewBag.role = new List<SelectListItem>{
                       new SelectListItem { Value = "isAdmin" , Text = "Admin" },
                       new SelectListItem { Value = "isManage" , Text = "Phòng Nghiên Cứu Khoa Học" },
                        new SelectListItem { Value = "isUser" , Text = "Giảng Viên" },
                         new SelectListItem { Value = "isStudent" , Text = "Sinh Viên" }
            };
            ViewBag.status = new List<SelectListItem>{
                       new SelectListItem { Value = "1" , Text = "Hoạt Động" },
                       new SelectListItem { Value = "0" , Text = "Khóa" },
            };
            ViewBag.Lec = get.Check(id);
            return View(model);
          
        }
        [HttpPost]
        public ActionResult Edit(string id, string role,string stt)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
