using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CalenderController : Controller
    {
        // GET: Calender
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Get()
        {
            return View();
        }
    }
}