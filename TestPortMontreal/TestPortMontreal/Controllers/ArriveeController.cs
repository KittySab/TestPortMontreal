using Microsoft.AspNetCore.Mvc;
using TestPortMontreal.Application.Arrivees;
using TestPortMontreal.Domain.Arrives;

namespace TestPortMontreal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArriveeController : ControllerBase
    {

        private readonly IArriveeService arriveeService;

        public ArriveeController(IArriveeService arriveeService)
        {
            this.arriveeService = arriveeService;
        }

        [HttpGet(Name = "GetArrivee")]
        public IEnumerable<Arrivee> Get()
        {
            return arriveeService.GetAllArrivees();
        }
    }
}
