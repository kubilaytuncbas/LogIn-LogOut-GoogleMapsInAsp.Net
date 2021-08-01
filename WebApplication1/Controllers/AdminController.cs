using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Siniflar;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
       
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Users.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(User user)
        {
            c.Users.Add(user);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var u = c.Users.Find(id);
            c.Users.Remove(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult GetUser(int id)
        {
            var u1 = c.Users.Find(id);
            return View("GetUser",u1);
        }
        public ActionResult Update(User user)
        {
            var us = c.Users.Find(user.Id);
            us.UserName = user.UserName;
            us.Password = user.Password;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}