using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tradirouting.Models;
namespace tradirouting.Controllers
{
    public class studentController : Controller
    {
        [Route("students")]
        public ActionResult getallstudents()
        {
            var student = students();
            return View(student);
        }
        [Route("students/{id}")]
        public ActionResult getstudent(int id)
        {
            var student = students().FirstOrDefault(x=>x.id ==id);
            return View();
        }
        [Route("students/{id}/address")]
        public ActionResult getstudentaddress(int id)
        {
            var studentaddress = students().Where(x => x.id == id).Select(x => x.address).FirstOrDefault();
            return View(studentaddress);
        }

        private List<student> students()

        {
            return new List<student>()
            {
                new student()
                {
                    id = 1,
                    name = "1 student",
                    class1 = "first",
                    address = new address()
                    {
                        address1 = "this is student 1",
                        city = "bhor",
                        homenumber = "student 1"
                    }
                },

                new student()
                {
                    id = 2,
                    name = "2 student",
                    class1 = "two",
                    address = new address()
                    {
                        address1 = "this is student 2",
                        city = "pune",
                        homenumber = "student 2"
                    }
                },
                new student()
                {
                    id = 3,
                    name = "3 student",
                    class1 = "three",
                    address = new address()
                    {
                        address1 = "this is student 3",
                        city = "satara",
                        homenumber = "student 3"
                    }
                },
                new student()
                {
                    id = 4,
                    name = "4 student",
                    class1 = "four",
                    address = new address()
                    {
                        address1 = "this is student 4",
                        city = "mumbai",
                        homenumber = "student 4"
                    }
                },
                new student()
                {
                    id = 5,
                    name = "5 student",
                    class1 = "five",
                    address = new address()
                    {
                        address1 = "this is student 5",
                        city = "nagpur",
                        homenumber = "student 5"
                    }
                },
                new student()
                {
                    id = 6,
                    name = "6 student",
                    class1 = "six",
                    address = new address()
                    {
                        address1 = "this is student 6",
                        city = "nashik",
                        homenumber = "student 6"
                    }
                }



            };
        }
    }
}