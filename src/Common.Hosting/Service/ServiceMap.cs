using Common.Service;
using System.Collections;

namespace Common.Hosting.Service
{
    public class ServiceMap<TService> : IServiceMap<TService>
    {
        protected IDictionary<string, TService> _instances;

        public ServiceMap(IDictionary<string, TService> instances)
        {
            _instances = instances;
        }

        protected ServiceMap()
        {
        }

        public TService Get(string name)
        {
            _instances.TryGetValue(name, out var instance);

            return instance;
        }

        public IEnumerator<IServiceMapEntry<TService>> GetEnumerator()
        {
            foreach (var (name, service) in _instances)
            {
                yield return new ServiceMapEntry(name, service);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _instances.Keys.GetEnumerator();
        }

        private record ServiceMapEntry(string Name, TService Service)
            : IServiceMapEntry<TService>
        {

        }
    }

    public static class ServiceMap
    {
        public static IServiceMap<TService> Create<TService>(IDictionary<string, TService> services)
        {
            return new ServiceMap<TService>(services);
        }
    }
}
