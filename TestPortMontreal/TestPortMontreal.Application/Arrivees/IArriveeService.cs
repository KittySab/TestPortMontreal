using TestPortMontreal.Domain.Arrives;

namespace TestPortMontreal.Application.Arrivees
{
    public interface IArriveeService
    {
        List<Arrivee> GetAllArrivees();
    }
}
