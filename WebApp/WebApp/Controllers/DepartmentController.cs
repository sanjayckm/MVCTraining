using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        private List<Department> DepartmentCollection;        
        public DepartmentController()
        {
            InitializeTestData();
        }
        private void InitializeTestData()
        {
            Random random = new Random();

            //Setup Department Data
            DepartmentCollection = new List<Department>();
            for (var i = 1; i <= 2; i++)
            {
                var d = new Department()
                {
                    Id = i,
                    Name = string.Concat("Dep", i.ToString())
                };
                DepartmentCollection.Add(d);
            }
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        // GET: Department
        public ActionResult Index()
        {
            return RedirectToAction("Get");
        }
        public ActionResult Get(int id=0)
        {
            if(id == 0)
                return View(DepartmentCollection);

            var department = DepartmentCollection.Where(d => d.Id == id).Select(d => d).FirstOrDefault();
            return View("DepartmentDetails", department);
        }
    }
}