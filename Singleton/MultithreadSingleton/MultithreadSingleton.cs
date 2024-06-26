using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.MultithreadSingleton
{
    public class MultithreadSingleton
    {
        private static MultithreadSingleton instance;
        private static readonly object lockObject = new object();

        private MultithreadSingleton()
        {
        }

        public static MultithreadSingleton GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new MultithreadSingleton();
                }
            }
            return instance;
        }
    }
}
