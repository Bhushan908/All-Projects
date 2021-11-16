using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class valuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(1);
        }
    }
}
