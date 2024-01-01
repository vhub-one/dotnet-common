using Common.Service;

namespace Common.Hosting.Service
{
    public class ServiceMapByServiceName<TService> : ServiceMap<TService>
    {
        public ServiceMapByServiceName(IEnumerable<TService> instances)
        {
            var instancesMap = new Dictionary<string, TService>();

            foreach (var instance in instances)
            {
                var instanceName = ServiceNameUtils.GetServiceName(instance);

                if (instanceName != null)
                {
                    instancesMap[instanceName] = instance;
                }
            }

            _instances = instancesMap;
        }
    }

    public static class ServiceMapByServiceName
    {
        public static IServiceMap<TService> Create<TService>(params TService[] instances)
        {
            return new ServiceMapByServiceName<TService>(instances);
        }
    }
}
