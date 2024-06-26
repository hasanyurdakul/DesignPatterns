using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Sample_2
{
    public class WindowsApp : ICreatorMobileApp
    {
        public void Platform()
        {
            Console.WriteLine("Windows Mobile");
        }
    }
}
