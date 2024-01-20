using System.Reflection;
using System.Resources;

namespace FIT.WinForms.Helpers
{
    public class Resursi
    {
        static ResourceManager Manager =
               new ResourceManager("FIT.WinForms.Resource1", Assembly.GetExecutingAssembly());

        public static string Get(string name)
        {
            return Manager.GetString(name);
        }
    }
}
