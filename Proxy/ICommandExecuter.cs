using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ICommandExecuter
    {
        public void RunCommand(string cmd); 

    }
}
