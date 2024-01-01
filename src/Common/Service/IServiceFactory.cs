
namespace Common.Service
{
    public interface IServiceFactory<TService>
    {
        public TService Create();
    }
}
