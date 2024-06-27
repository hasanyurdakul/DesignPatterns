using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarBaseDecorator : CarBase
    {
        private CarBase _carBase;
        protected CarBaseDecorator(CarBase carBase)
        {
            _carBase = carBase;
        }
        

    }
}
