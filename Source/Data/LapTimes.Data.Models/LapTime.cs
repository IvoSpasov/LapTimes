namespace LapTimes.Data.Models
{
    using System;

    public class LapTime
    {
        public int Id { get; set; }

        public TimeSpan Time { get; set; }

        public DateTime RecordedOn { get; set; }
    }
}
