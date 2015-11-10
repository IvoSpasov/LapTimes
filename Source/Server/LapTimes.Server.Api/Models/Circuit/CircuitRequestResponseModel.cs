namespace LapTimes.Server.Api.Models.Circuit
{
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CircuitRequestResponseModel : IMapFrom<Circuit>
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}