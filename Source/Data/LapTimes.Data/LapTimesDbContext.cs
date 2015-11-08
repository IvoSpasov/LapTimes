namespace LapTimes.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class LapTimesDbContext : IdentityDbContext<User>
    {
        public LapTimesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static LapTimesDbContext Create()
        {
            return new LapTimesDbContext();
        }
    }
}
