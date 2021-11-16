using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication5
{
    public static class Class1
    {
        public static IHtmlString image (string src,string alt)
        {
            return new MvcHtmlString(string.Format("<img src={0}' alt=''{1}'></img>"), src,alt));
        }
    }
}