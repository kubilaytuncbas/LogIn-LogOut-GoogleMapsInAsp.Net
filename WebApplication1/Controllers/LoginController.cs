using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models.Siniflar;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var bilgiler = c.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password==user.Password);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.UserName, false);
                Session["UserName"] = bilgiler.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.msg = "HATALI";
                return View();
                
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}