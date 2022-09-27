using DiWorkshop.Other;

namespace DiWorkshop.Repos
{
    public interface ISingleDependencyRepository
    {

    }
    
    public class SingleDependencyRepository : ISingleDependencyRepository
    {
        private readonly AnotherClassDependency _anotherClassDependency;

        public SingleDependencyRepository(AnotherClassDependency anotherClassDependency)
        {
            _anotherClassDependency = anotherClassDependency;
        }
    }
}
