using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface ISimilarDependencyService : IBaseService
    {

    }
    
    public class SimilarDependencyService : BaseService, ISimilarDependencyService
    {
        private readonly ISimilarRepository _similarRepository;

        public SimilarDependencyService(ISimilarRepository similarRepository)
        {
            _similarRepository = similarRepository;
        }
    }
}
