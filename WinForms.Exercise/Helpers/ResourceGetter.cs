using System.Reflection;
using System.Resources;

namespace WinForms.Exercise.Helpers
{
    public class ResourceGetter
    {
        private static ResourceManager resourceManager = new ResourceManager("WinForms.Exercise.Resources.Localization", Assembly.GetExecutingAssembly());
        public static string Get(string key)
        {
            return resourceManager.GetString(key)!;
        }

        public static string Get(string key, string replacement1)
        {
            return string.Format(resourceManager.GetString(key), replacement1);
        }
    }
}