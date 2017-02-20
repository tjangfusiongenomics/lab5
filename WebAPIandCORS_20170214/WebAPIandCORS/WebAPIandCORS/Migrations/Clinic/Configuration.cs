namespace WebAPIandCORS.Migrations.Clinic
{
    using Models.Clinic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIandCORS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Clinic";
        }

        protected override void Seed(WebAPIandCORS.Models.ApplicationDbContext context)
        {
            context.Medications.AddOrUpdate(
                      m => m.Name,
                      DummyData.GetMedication().ToArray()
                );

            context.SaveChanges();

            context.Ailments.AddOrUpdate(
                  a => a.Name,
                  DummyData.GetAilments().ToArray()
            );

            context.SaveChanges();

            context.Patients.AddOrUpdate(
                  p => p.Name,
                  DummyData.GetPatients(context).ToArray()
                );
        }
    }
}
