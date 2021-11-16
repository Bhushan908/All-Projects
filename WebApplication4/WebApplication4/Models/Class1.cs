using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class class1
    {
        public int id { get; set; }
       
        public string name { get; set; }

        public string email { get; set; }

        public bool isonline { get; set; }

        public DateTime dateofbirth { get; set; }
    }
}