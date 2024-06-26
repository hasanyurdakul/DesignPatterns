using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Sample_1
{
    public class FactoryCreator
    {
        public static CreatorComputer FactoryComputer(string computerType, string ram, string memory, string hdd, string cpu)
        {
            if (computerType == "gamerComputer")
            {
                return new CreatorGamerComputer(cpu, hdd, memory, ram);
            }
            else if (computerType == "developerComputer")
            {
                return new CreatorDeveloperComputer(cpu, hdd, memory, ram);
            }
            else
            {
                return null;
            }
        }
    }
}
