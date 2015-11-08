namespace LapTimes.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Vehicle
    {
        private ICollection<Driver> drivers;

        public Vehicle()
        {
            this.Drivers = new HashSet<Driver>();
        }

        public int Id { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        public virtual ICollection<Driver> Drivers
        {
            get { return this.drivers; }
            set { this.drivers = value; }
        }
    }
}
