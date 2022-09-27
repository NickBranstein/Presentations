using DiWorkshop.Domain;
using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface IGenericRepositoryDependencyService : IBaseService
    {

    }

    public class GenericRepositoryDependencyService : BaseService, IGenericRepositoryDependencyService
    {
        private readonly IGenericRepository<Cat> _genericRepository;

        public GenericRepositoryDependencyService(IGenericRepository<Cat> genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
