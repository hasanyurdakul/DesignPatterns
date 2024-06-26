using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CommandExecuter : ICommandExecuter
    {
        public void RunCommand(string cmd)
        {
            Console.WriteLine($"{cmd} Command Executed");
        }
    }
}
