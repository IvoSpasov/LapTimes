namespace LapTimes.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class LapTime
    {
        public int Id { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public DateTime RecordedOn { get; set; }

        public int CircuitId { get; set; }

        public virtual Circuit Circuit { get; set; }

        public int DriverId { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
