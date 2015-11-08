namespace LapTimes.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Driver
    {
        private ICollection<LapTime> lapTimes;
        private ICollection<Vehicle> vehicles;

        public Driver()
        {
            this.LapTimes = new HashSet<LapTime>();
            this.Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<LapTime> LapTimes
        {
            get { return this.lapTimes; }
            set { this.lapTimes = value; }
        }

        public virtual ICollection<Vehicle> Vehicles
        {
            get { return this.vehicles; }
            set { this.vehicles = value; }
        }
    }
}
