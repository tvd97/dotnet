using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using UPES3.Data.LogicLayer;
using UPES3.Models;
using Microsoft.Office.Interop.Word;
using System.Web.UI.WebControls;
using System.Text;

namespace UPES3.Controllers
{
    public class HomeController : Controller
    {
        NotificationDLL DLL = new NotificationDLL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            var model = DLL.getListNotifications();
            return View(model);
        }
        public ActionResult DetailNotification(int id)
        {
            if(id == 0)
            {
                return RedirectToAction("Notifications");
            }    
            var model = DLL.getDetailNotification(id);
            return View(model);
        }
        public ActionResult Classity()
        {
            var model = new ClassityDLL().getClasssity();
            return View(model);
        }

    }
}