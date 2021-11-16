using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIinMVC.Controllers
{
    public class ValueController : ApiController
    {
        public IHttpActionResult Get()
        {
            return ok(1);
        }
    }
}
