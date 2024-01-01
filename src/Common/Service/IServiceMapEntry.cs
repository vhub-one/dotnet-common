
namespace Common.Service
{
    public interface IServiceMapEntry<out TService>
    {
        public string Name { get; }
        public TService Service { get; }
    }
}
