using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class MSSQLConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("MSSQL Connection Closed");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("MSSQL Connection Opened");
            return true;
        }
    }
}
