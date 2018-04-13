using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class TwoController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        // GET: Two
        [HttpGet]
        public string Get()
        {
            return "Response to Get Request";
        }

        [HttpPost]
        public string Get(string name)
        {
            if(name == null)
                return string.Format("Response to Post Request.");

            return string.Format("Hello {0}, Response to Post Request.", name);
        }
    }
}