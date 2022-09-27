using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface ISingleDependencyMultiLayerService : IBaseService
    {

    }
    
    public class SingleDependencyMultiLayerService : BaseService, ISingleDependencyMultiLayerService
    {
        private readonly ISingleDependencyRepository _singleDependencyRepository;

        public SingleDependencyMultiLayerService(ISingleDependencyRepository singleDependencyRepository)
        {
            _singleDependencyRepository = singleDependencyRepository;
        }
    }
}
