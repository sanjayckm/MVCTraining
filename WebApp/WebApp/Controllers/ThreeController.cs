using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ThreeController : Controller
    {
        private List<Department> DepartmentCollection;
        private List<Employee> EmployeeCollection;

        public ThreeController()
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
                    Name = RandomString(random.Next(4, 8), false)
                };
                DepartmentCollection.Add(d);                
            }

            //Setup Employees Data
            EmployeeCollection = new List<Employee>();
            for (var i = 1; i<= 10; i++)
            {
                var e = new Employee()
                {
                    Id = i,
                    Name = RandomString(random.Next(5, 8), false),
                    DepartmentId = (i % 2) + 1
                };
                EmployeeCollection.Add(e);
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

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllDepartments()
        {
            return View(DepartmentCollection);
        }

        public ActionResult AllEmployees()
        {
            return View(EmployeeCollection);
        }
    }
}