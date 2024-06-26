using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SampleSingleton
    {
        private static SampleSingleton instance;
        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        protected SampleSingleton()
        {
        }
        public static SampleSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new SampleSingleton();
            }
            return instance;
        }
    }
}
