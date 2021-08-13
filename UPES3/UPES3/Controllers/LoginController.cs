using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UPES3.Data.LogicLayer;
using UPES3.Models.LoginModel;

namespace UPES3.Controllers
{
    public class LoginController : Controller
    {
        Login signin = new Login();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model,string returnURL="/login/index")
        {
            if(ModelState.IsValid)
            {
                var result = signin.Signin(model.username, model.password);
                if(result==1)
                {
                    var ses = signin.GetAccount(model.username);
                    Session["user"] = ses.userName;
                    Session["Role"] = ses.role;
                    Session.Add(ConstantSession.USER, ses);
                    Session.Timeout = 30;
                    FormsAuthentication.SetAuthCookie(model.username, false);
                    if (Url.IsLocalUrl(returnURL) && returnURL.Length > 1 && returnURL.StartsWith("/") && returnURL.StartsWith("//") && returnURL.StartsWith("/\\"))
                    {
                        return Redirect(returnURL);
                    }

                    if ("isAdmin" == ses.role)
                    {
                        return RedirectToAction("index", "admin");
                    }
                    else
                        return RedirectToAction("index", "home");
                } 
                else if(result==0)
                {
                    ModelState.AddModelError("", "Tài Khoản Đã Khóa");
                }  
                else
                {
                    ModelState.AddModelError("", "Sai Tài Khoản Hoặc Mật Khẩu");
                }    
            }    
            return View("index");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            Session.RemoveAll();
            FormsAuthentication.SignOut();

            return RedirectToAction("index", "Login");
        }
    }
}