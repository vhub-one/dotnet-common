using System.Reflection;

namespace Common.Hosting.Service
{
    public static class ServiceNameUtils
    {
        public static string GetServiceName<TInstance>(TInstance instance)
        {
            var instanceType = instance.GetType();
            var instanceTypeAttributes = instanceType.GetCustomAttributes<ServiceNameAttribute>(true);

            foreach (var attribute in instanceTypeAttributes)
            {
                return attribute.Name;
            }

            return null;
        }
    }
}