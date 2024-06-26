using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class Command
    {
        public abstract void ExecuteCommand(string query);
    }
}
