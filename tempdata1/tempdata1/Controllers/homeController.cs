using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tempdata1.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            TempData["my key"] = "this is my key";
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.mykey = TempData["my key"];
            TempData.Keep("my key");
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.mykey = TempData["my key"];
            return View();
        }
    }
}