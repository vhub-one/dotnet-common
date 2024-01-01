
namespace Common.Hosting.Service
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceNameAttribute : Attribute
    {
        public ServiceNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}