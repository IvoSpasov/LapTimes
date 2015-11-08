namespace LapTimes.Server.Api
{
    using System.Data.Entity;

    using Data;
    using Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LapTimesDbContext, Configuration>());
            LapTimesDbContext.Create().Database.Initialize(true);
        }
    }
}