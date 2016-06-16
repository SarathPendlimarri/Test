using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controller
{
    [RoutePrefix("Test") ]
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("Hello")]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [HttpPost]
        [Route("{saved:int=90}") ]
        public string SaveWorld(string Saved)
        {
            return "Hello World";
        }
    }
}
