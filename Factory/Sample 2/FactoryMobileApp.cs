using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Sample_2
{
    public class FactoryMobileApp
    {
        public static ICreatorMobileApp CreateMobileApp(string type)
        {
            switch (type)
            {
                case "Windows":
                    return new WindowsApp();
                case "Android":
                    return new AndroidApp();
                case "IOS":
                    return new IOSApp();
                default:
                    return null;
            }
        }
    }
}
