using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES3.Data.LogicLayer;
using UPES3.Models.LoginModel;

namespace UPES3.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Info()
        {
           
            var model = new AccountDLL().getInfo(ConstantSession.USER);
            return View(model);
        }
    }
}