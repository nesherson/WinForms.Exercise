using System.Reflection;
using System.Resources;

namespace WinForms.Exercise.Helpers
{
    public class Resursi
    {
        private static ResourceManager resourceManager = new("WinForms.Exercise.Resource1", Assembly.GetExecutingAssembly());

        public static string Get(string kljuc)
        {
            return resourceManager.GetString(kljuc);
        }
    }
}