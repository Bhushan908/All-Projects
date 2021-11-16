using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewbagdata.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            ViewBag.myname = "bhushan bandal";
            ViewBag.mylist = new List<string>() { "jon", "marh", "sjs", "dsk" };
            return View();
        }
    }
}