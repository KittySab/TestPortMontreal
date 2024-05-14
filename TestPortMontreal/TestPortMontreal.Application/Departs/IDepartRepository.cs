using TestPortMontreal.Domain.Departs;

namespace TestPortMontreal.Application.Departs
{
    public interface IDepartRepository
    {
        List<Depart> GetAllDeparts();
    }
}
