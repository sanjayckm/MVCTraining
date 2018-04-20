using EFExampleTwo.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFExampleTwo.Controllers
{
    public class HelpersController : Controller
    {
        // GET: Helpers
        public ActionResult Index()
        {
            var student = new Student()
            {
                StudentId = Guid.NewGuid().ToString(),
                StudentName = "Abcde xyz",
                DateOfJoin = new DateTime(2000, 6, 30),
                Notes = "Medical history of the student"
            };
            return View(student);
        }
    }
}