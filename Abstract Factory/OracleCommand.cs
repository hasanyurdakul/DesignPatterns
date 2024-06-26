using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            Console.WriteLine("Oracle Command Executed");
        }
    }
}
