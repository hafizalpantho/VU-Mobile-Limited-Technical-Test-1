using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technical_Test.Models;

namespace Technical_Test.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        LoginContext context = new LoginContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login log)
        {

            var user = context.Logins.Where(x => x.UserName == log.UserName && x.Password == log.Password).Count();
            if(user >0)
            {
                return RedirectToAction("Welcome");

            }
            else
            {
                ViewBag.Message = "Sorry wrong information given";
                return View();
            }
            
            
        }
        public ActionResult Welcome()
        {
            return View();
        }

    }
}