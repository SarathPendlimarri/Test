using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    [RoutePrefix("Default")]
    public class DefaultController : Controller
    {
        // GET: Default
        [Route("Index")]
        public async Task<ActionResult> Index()
        {
            //WebClient client = new WebClient();
            //client.BaseAddress=@"http://localhost:58951/test";
            //client.
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58951/test");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("Hello");
                if (response.IsSuccessStatusCode)
                {
                    var ste = await response.Content.ReadAsStringAsync();

                }
            }
            return View();
        }
    }
}