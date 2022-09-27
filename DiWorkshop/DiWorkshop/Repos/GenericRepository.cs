using DiWorkshop.Domain;

namespace DiWorkshop.Repos
{
    public interface IGenericRepository<T> where T : BaseEntity
    {

    }

    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

    }
}
