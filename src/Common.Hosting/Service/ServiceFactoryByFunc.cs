using Common.Service;

namespace Common.Hosting.Service
{
    public class ServiceFactoryByFunc<TService> : IServiceFactory<TService>
    {
        private readonly Func<TService> _createFunc;

        public ServiceFactoryByFunc(Func<TService> createFunc)
        {
            _createFunc = createFunc;
        }

        public TService Create()
        {
            return _createFunc();
        }
    }
}
