using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface ISingleDependencyService : IBaseService
    {

    }

    public class SingleDependencyService : BaseService, ISingleDependencyService
    {
        private readonly IEmptyRepository _emptyRepository;
        
        public SingleDependencyService(IEmptyRepository emptyRepository)
        {
            _emptyRepository = emptyRepository;
        }
    }
}
