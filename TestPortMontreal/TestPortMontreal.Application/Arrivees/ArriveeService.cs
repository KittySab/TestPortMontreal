using TestPortMontreal.Domain.Arrives;

namespace TestPortMontreal.Application.Arrivees
{
    public class ArriveeService : IArriveeService
    {
        private readonly IArriveeRepository arriveeRepository;
        public ArriveeService(IArriveeRepository arriveeRepository)
        {
            this.arriveeRepository = arriveeRepository;
        }
        public List<Arrivee> GetAllArrivees()
        {
           return arriveeRepository.GetAllArrivees();
        }
    }
}
