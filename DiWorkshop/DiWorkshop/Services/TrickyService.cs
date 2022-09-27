using DiWorkshop.Domain;
using DiWorkshop.Repos;

namespace DiWorkshop.Services
{
    public interface ITrickyService<T> : IBaseService where T : BaseEntity
    {

    }
    
    public class TrickyService<T> : BaseService, ITrickyService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _genericRepository;

        public TrickyService(IGenericRepository<T> genericRepository) 
        {
            _genericRepository = genericRepository;
        }
    }
}
