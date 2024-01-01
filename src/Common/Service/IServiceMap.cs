
namespace Common.Service
{
    public interface IServiceMap<out TService> : IEnumerable<IServiceMapEntry<TService>>
    {
        TService Get(string name);
    }
}
