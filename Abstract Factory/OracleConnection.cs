using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("Oracle Connection Opened");
            return true;
        }
    }
}
