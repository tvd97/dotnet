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
        public ActionResult Form()
        {
            string[] filePath = Directory.GetFiles(Server.MapPath("~/FileManager/Text-Form/"));
            List<FileModel> list = new List<FileModel>();
            foreach(string path in filePath)
            {
                double size =(double) new FileInfo(path).Length/1024/1024;
                list.Add(new FileModel { fileName = Path.GetFileName(path),fileSize=Math.Round(size,3)});
            }    
            return View(list);
        }

        public ActionResult ViewForm(string fileName)
        {
            Application ac = new Application();   
            Document doc = new Microsoft.Office.Interop.Word.Document();
           // doc= ac.do
            string Content = System.IO.File.ReadAllText(Server.MapPath("~/FileManager/Text-Form/" + fileName));
            foreach (Match match in Regex.Matches(Content, "<v:imagedata.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase))
            {
                Content = Regex.Replace(Content, match.Groups[1].Value, "FileManager/Text-Form/" + match.Groups[1].Value);
            }
            ViewBag.content = Content;
            return View();
        }
    }
}