using TestPortMontreal.Domain.Departs;

namespace TestPortMontreal.Application.Departs
{
    public interface IDepartService
    {
        List<Depart> GetAllDeparts();
    }
}
