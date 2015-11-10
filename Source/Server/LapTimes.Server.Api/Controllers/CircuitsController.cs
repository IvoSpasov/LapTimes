namespace LapTimes.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper;
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
                .ProjectTo<CircuitRequestResponseModel>()
                .ToList();

            return Ok(circuits);
        }

        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return this.BadRequest("Circuit id cannot be null");
            }

            var circuitFromDb = this.circuitsRepository
                .GetById(id);

            if (circuitFromDb == null)
            {
                return this.NotFound();
            }

            var circuit = Mapper.Map<CircuitRequestResponseModel>(circuitFromDb);
            return this.Ok(circuit);
        }

        // [Authorize]
        public IHttpActionResult Post(CircuitRequestResponseModel circuit)
        {
            if (circuit == null)
            {
                return this.BadRequest("Cirucit cannot be null.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newCircuit = Mapper.Map<Circuit>(circuit);
            this.circuitsRepository.Add(newCircuit);
            this.circuitsRepository.SaveChanges();

            return this.Ok(newCircuit.Id);
        }
    }
}