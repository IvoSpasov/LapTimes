namespace LapTimes.Data
{
    using System.Data.Entity;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class LapTimesDbContext : IdentityDbContext<User>
    {
        public LapTimesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Circuit> Circuits { get; set; }

        public IDbSet<Driver> Drivers { get; set; }

        public IDbSet<LapTime> LapTimes { get; set; }

        public IDbSet<Vehicle> Vehicles { get; set; }

        public static LapTimesDbContext Create()
        {
            return new LapTimesDbContext();
        }
    }
}
