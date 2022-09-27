using DiWorkshop.Domain;
using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface IMultiGenericRepositoryDependencyService : IBaseService
    {

    }

    public class MulitGenericRepositoryDependencyService : BaseService, IMultiGenericRepositoryDependencyService
    {
        private readonly IGenericRepository<Dog> _dogRepository;
        private readonly IGenericRepository<Zebra> _zebraRepository;

        public MulitGenericRepositoryDependencyService(IGenericRepository<Dog> dogRepository, IGenericRepository<Zebra> zebraRepository)
        {
            _dogRepository = dogRepository;
            _zebraRepository = zebraRepository;
        }
    }
}
