using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using validation.Models; 
namespace validation.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submitdata(employee emp)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("index");
        }
    }
}