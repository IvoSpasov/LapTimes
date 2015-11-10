namespace LapTimes.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data.Common.Repositories;
    using Data.Models;

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
                .ToList();

            return Ok(circuits);
        }
    }
}