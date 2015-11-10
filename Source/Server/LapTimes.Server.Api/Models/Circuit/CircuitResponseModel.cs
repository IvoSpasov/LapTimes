namespace LapTimes.Server.Api.Models.Circuit
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class CircuitResponseModel : IMapFrom<Circuit>
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}