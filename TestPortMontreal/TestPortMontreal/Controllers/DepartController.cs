using Microsoft.AspNetCore.Mvc;
using TestPortMontreal.Application.Departs;
using TestPortMontreal.Domain.Departs;

namespace TestPortMontreal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartController : ControllerBase
    {

        private readonly IDepartService departService;

        public DepartController(IDepartService departService)
        {
            this.departService = departService;
        }

        [HttpGet(Name = "GetDepart")]
        public IEnumerable<Depart> Get()
        {
            return departService.GetAllDeparts();
        }
    }
}
