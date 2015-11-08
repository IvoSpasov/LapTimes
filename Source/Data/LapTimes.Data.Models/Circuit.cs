namespace LapTimes.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Circuit
    {
        private ICollection<LapTime> lapTimes;

        public Circuit()
        {
            this.LapTimes = new HashSet<LapTime>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<LapTime> LapTimes
        {
            get { return this.lapTimes; }
            set { this.lapTimes = value; }
        }
    }
}
