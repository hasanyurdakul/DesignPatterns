using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public abstract decimal ListPrice { get; set; }

    }
}
