namespace LapTimes.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Data.Common.Repositories;
    using Data.Models;
    using Models.Circuit;

    public class CircuitsController : ApiController
    {
        private IRepository<Circuit> circuitsRepository;

        public CircuitsController(IRepository<Circuit> circuitsRepository)
        {
            this.circuitsRepository = circuitsRepository;
        }

        public IHttpActionResult Get()
        {
            var circuits = this.circuitsRepository
                .All()
                .ProjectTo<CircuitResponseModel>()
                .ToList();

            return Ok(circuits);
        }
    }
}