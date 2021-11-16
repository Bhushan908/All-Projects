using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            class1 emp = new class1()
            {
                id = 1,
                name = "rahul",
                email = "bhushal32@gmail.com",
                isonline = true,
                dateofbirth = DateTime .Now
            };
            return View(emp);
        }
    }
}