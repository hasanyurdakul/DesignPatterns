using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lazy Singleton Design Pattern
namespace Singleton
{
    public class SystemManager
    {
        private static SystemManager systemManager;
        private SystemManager()
        {
            //Bu constructor'ı private yaparak dışarıdan erişimi ve instance alınmasını engelledik.
        }
        public static SystemManager CreateSingletonObject()
        {
            if (systemManager == null)
            {
                systemManager = new SystemManager();
            }
            return systemManager;
        }

        public void CreateLog()
        {
            Console.WriteLine("This is a log.");
        }
    }
}
