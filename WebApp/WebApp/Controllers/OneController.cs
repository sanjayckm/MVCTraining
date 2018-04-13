using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class OneController : Controller
    {
        // GET: One
        public ActionResult Index()
        {
            return View();
        }

        public string StringOutput()
        {
            return "String output from action";
        }

        public ContentResult ContentOutput()
        {
            return Content("Content output from action");
        }

        public ViewResult ViewOutput()
        {
            return View();
        }

        public ViewResult ViewByName(string name="ViewByName")
        {
            return View(name);
        }
    }
}