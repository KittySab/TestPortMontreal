using TestPortMontreal.Domain.Arrives;

namespace TestPortMontreal.Application.Arrivees
{
    public interface IArriveeRepository
    {
        List<Arrivee> GetAllArrivees();
    }
}
