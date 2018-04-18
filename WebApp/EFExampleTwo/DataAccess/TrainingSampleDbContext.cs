using EFExampleTwo.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFExampleTwo.DataAccess
{
    public class TrainingSampleDbContext : DbContext
    {
        public TrainingSampleDbContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}