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
            var nürburgring = new Circuit() { Name = "Nürburgring" };
            var suzuka = new Circuit() { Name = "Suzuka" };
            context.Circuits.AddOrUpdate(c => c.Name, nürburgring);
            context.Circuits.AddOrUpdate(c => c.Name, suzuka);

            var gtr = new Vehicle() { Manufacturer = "Nissan", Model = "GTR Nismo" };
            var aventadorSv = new Vehicle() { Manufacturer = "Lamborghini", Model = "Aventador SV" };
            var lfa = new Vehicle() { Manufacturer = "Lexus", Model = "LFA Nürburgring Package" };
            var civic = new Vehicle() { Manufacturer = "Honda", Model = "Civic Type-R JDM (FD2)" };
            context.Vehicles.AddOrUpdate(v => v.Model, gtr);
            context.Vehicles.AddOrUpdate(v => v.Model, aventadorSv);
            context.Vehicles.AddOrUpdate(v => v.Model, lfa);
            context.Vehicles.AddOrUpdate(v => v.Model, civic);

            var krumm = new Driver()
            {
                FirstName = "Michael",
                LastName = "Krumm",
                Vehicles = { gtr }                
            };
            var mapelli = new Driver()
            {
                FirstName = "Marco",
                LastName = "Mapelli",
                Vehicles = { aventadorSv }
            };
            var iida = new Driver()
            {
                FirstName = "Akira",
                LastName = "Iida",
                Vehicles = { lfa }
            };
            var tsuchiya = new Driver()
            {
                FirstName = "Keiichi",
                LastName = "Tsuchiya",
                Vehicles = { civic }
            };
            context.Drivers.AddOrUpdate(d => d.FirstName, krumm);
            context.Drivers.AddOrUpdate(d => d.FirstName, mapelli);
            context.Drivers.AddOrUpdate(d => d.FirstName, iida);
            context.Drivers.AddOrUpdate(d => d.FirstName, tsuchiya);

            var lapTime1 = new LapTime()
            {
                Time = new TimeSpan(0, 0, 7, 8, 69),
                RecordedOn = new DateTime(2013, 9, 30),
                Circuit = nürburgring,
                Driver = krumm
            };
            var lapTime2 = new LapTime()
            {
                Time = new TimeSpan(0, 0, 6, 59, 73),
                RecordedOn = new DateTime(2015, 5, 18),
                Circuit = nürburgring,
                Driver = mapelli
            };
            var lapTime3 = new LapTime()
            {
                Time = new TimeSpan(0, 0, 7, 14, 64),
                RecordedOn = new DateTime(2011, 8, 31),
                Circuit = nürburgring,
                Driver = iida
            };
            var lapTime4 = new LapTime()
            {
                Time = new TimeSpan(0, 0, 2, 35, 20),
                RecordedOn = new DateTime(2015, 1, 1),
                Circuit = suzuka,
                Driver = tsuchiya
            };
            context.LapTimes.AddOrUpdate(l => l.Time, lapTime1);
            context.LapTimes.AddOrUpdate(l => l.Time, lapTime2);
            context.LapTimes.AddOrUpdate(l => l.Time, lapTime3);
            context.LapTimes.AddOrUpdate(l => l.Time, lapTime4);
        }
    }
}
