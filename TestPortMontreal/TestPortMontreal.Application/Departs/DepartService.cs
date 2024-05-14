using TestPortMontreal.Domain.Departs;

namespace TestPortMontreal.Application.Departs
{
    public class DepartService : IDepartService
    {
        private readonly IDepartRepository departRepository;
        public DepartService(IDepartRepository departRepository)
        {
            this.departRepository = departRepository;
        }
        public List<Depart> GetAllDeparts()
        {
           return departRepository.GetAllDeparts();
        }
    }
}
