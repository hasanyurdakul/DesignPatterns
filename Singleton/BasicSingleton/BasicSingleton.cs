using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.BasicSingleton
{
    public class BasicSingleton
    {
        /*
         * Eager Initialization olarak adlandırılan bu yapı, sınıfın örneğini sınıf yüklemesi sırasında (dotnet run) oluşturur.         * 
         */
        private static BasicSingleton instance;

        private BasicSingleton()
        {

        }

        public static BasicSingleton GetInstance()
        {
            return instance;
        }
    }
}
