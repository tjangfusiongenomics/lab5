namespace lab5application.Migrations.Student
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<lab5application.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Student";
        }

        protected override void Seed(lab5application.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Students.AddOrUpdate(
                p => p.Id,
                 new Models.Student
                 {
                     FirstName = "Ann",
                     LastName = "Lee",
                     Major = "Medicine",
                     DateOfBirth = Convert.ToDateTime("2004/09/09")
                 },
                  new Models.Student
                  {
                      FirstName = "Bob",
                      LastName = "Doe",
                      Major = "Engineering",
                      DateOfBirth = Convert.ToDateTime("2005/09/09")
                  },
                  new Models.Student
                  {
                      FirstName = "Sue",
                      LastName = "Douglas",
                      Major = "Pharmacy",
                      DateOfBirth = Convert.ToDateTime("2006/01/01")
                  },
                  new Models.Student
                  {
                      FirstName = "Tom",
                      LastName = "Brown",
                      Major = "Business",
                      DateOfBirth = Convert.ToDateTime("2000/09/09")
                  },
                  new Models.Student
                  {
                      FirstName = "Joe",
                      LastName = "Mason",
                      Major = "Health",
                      DateOfBirth = Convert.ToDateTime("2001/01/01")
                  }
            );
        }
    }
}
