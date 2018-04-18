namespace EFExampleTwo.Migrations
{
    using EFExampleTwo.DataAccess.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFExampleTwo.DataAccess.TrainingSampleDbContext>
    {
        private DbSet<Department> department { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFExampleTwo.DataAccess.TrainingSampleDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //department.AddOrUpdate(new Department() {
            //    DepartmentId ="Dept1",
            //    DepartmentName = "EC"
            //}) 
        }
    }
}
