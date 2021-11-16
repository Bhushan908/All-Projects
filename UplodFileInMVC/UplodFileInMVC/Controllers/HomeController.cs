using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO; 
using UplodFileInMVC.Models;


namespace UplodFileInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            string path = Server.MapPath("~/App_Data/file");
            string fileName = path.GetFileName(emp.FileName);
            string fullpath = path.Combine(path, fileName);
            emp.File.SaveAs(fullpath);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}