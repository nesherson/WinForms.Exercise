using System.Reflection;
using System.Resources;

namespace WinForms.Exercise.Helpers
{
    public class Resources
    {
        public static string Get(string key)
        {
            var resourceManager = new ResourceManager("WinForms.Exercise.Resources.Localization.resx", Assembly.GetExecutingAssembly());
            return resourceManager.GetString(key)!;
        }
    }
}