using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UplodFileInMVC.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public HttpPostedFileBase File { get; set; }
    }
}