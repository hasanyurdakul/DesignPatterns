﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class MSSQLDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MSSQLCommand();
        }

        public Connection CreateConnection()
        {
            return new MSSQLConnection();
        }
    }
}