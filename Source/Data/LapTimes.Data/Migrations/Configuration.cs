namespace LapTimes.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<LapTimesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LapTimesDbContext context)
        {
            var circuit1 = new Circuit() { Name = "Nürburgring" };
            context.Circuits.AddOrUpdate(c => c.Name, circuit1);

            var vehicle1 = new Vehicle() { Manufacturer = "Nissan", Model = "GTR Nismo" };
            context.Vehicles.AddOrUpdate(v => v.Model, vehicle1);

            var driver1 = new Driver()
            {
                FirstName = "Michael",
                LastName = "Krumm",
                Vehicles = { vehicle1 }
            };
            context.Drivers.AddOrUpdate(d => d.FirstName, driver1);

            var lapTime1 = new LapTime()
            {
                Time = new TimeSpan(0, 0, 7, 8, 69),
                RecordedOn = new DateTime(2013, 9, 30),
                CircuitId = circuit1.Id,
                DriverId = driver1.Id
            };
            context.LapTimes.AddOrUpdate(l => l.Time, lapTime1);
        }
    }
}
