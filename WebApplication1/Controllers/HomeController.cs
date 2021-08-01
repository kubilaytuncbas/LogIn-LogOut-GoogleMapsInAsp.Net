using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Siniflar;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string DisplayDate(Calender calender)
        {
            if (ModelState.IsValid)
            {
                return "Date have been selected by you : <b>" + calender.Tarih.ToString() + "</b>";
            }
            return "Please select any date ";
        }

    }
}