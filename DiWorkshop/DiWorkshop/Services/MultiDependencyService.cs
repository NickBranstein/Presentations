using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface IMultiDependencyService : IBaseService
    {

    }
    
    public class MultiDependencyService : BaseService, IMultiDependencyService
    {
        private readonly IEmptyRepository _emptyRepository;
        private readonly IAnotherEmptyRepository _anotherRepository;

        public MultiDependencyService(IEmptyRepository emptyRepository, IAnotherEmptyRepository anotherRepository)
        {
            _emptyRepository = emptyRepository;
            _anotherRepository = anotherRepository;
        }
    }
}
