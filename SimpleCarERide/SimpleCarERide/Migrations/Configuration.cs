namespace SimpleCarERide.Migrations
{
    using SimpleCarERide.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleCarERide.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleCarERide.Models.ApplicationDbContext context)
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

            // Setup CarTypes 
            /*context.CarTypes.AddOrUpdate(
                t => t.ShortName,
                new CarType
                {
                    Id = 0,
                    ShortName = "SM42",
                    FullName = "Smart Fortwo",
                    TagLine = "zippy and easy to park",
                    FullDescription = @"The smart fortwo can fit in almost any parking spot and can maneuver around even the craziest downtown rush hour traffic jams.",
                    RatePerMinute = 0.41,
                    RatePerHour = 15.0,
                    RatePerDay = 59.0,
                    ImageReference = ""
                }
                ); */
        }
    }
}
