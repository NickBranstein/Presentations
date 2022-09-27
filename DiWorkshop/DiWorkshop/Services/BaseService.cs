namespace DiWorkshop.Services
{
    public interface IBaseService
    {
        bool ReturnsTrueForTest();
    }

    public abstract class BaseService : IBaseService
    {
        public bool ReturnsTrueForTest()
        {
            return true;
        }
    }
}
