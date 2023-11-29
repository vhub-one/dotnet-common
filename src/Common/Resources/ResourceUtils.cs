using System.Reflection;

namespace Common.Resources
{
    public static class ResourceUtils
    {
        public static string ReadForCallingAssembly(string key)
        {
            var assembly = Assembly.GetCallingAssembly();

            return ReadForAssembly(assembly, key);
        }

        public static string ReadForAssemblyType<AssemblyType>(string key)
        {
            var assembly = typeof(AssemblyType).Assembly;

            return ReadForAssembly(assembly, key);
        }

        public static string ReadForAssembly(Assembly assembly, string key)
        {
            using var stream = assembly.GetManifestResourceStream(key);
            using var streamReader = new StreamReader(stream);

            return streamReader.ReadToEnd();
        }
    }
}
