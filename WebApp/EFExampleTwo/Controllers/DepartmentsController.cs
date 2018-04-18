using EFExampleTwo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFExampleTwo.Controllers
{
    public class DepartmentsController : Controller
    {
        private TrainingSampleDbContext db = new TrainingSampleDbContext();
        // GET: Departments
        public ActionResult Index()
        {
            var departments = db.Departments.ToList();
            return View(departments);
        }

    }
}