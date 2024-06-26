using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Sample_1
{
    public class CreatorDeveloperComputer : CreatorComputer
    {
        private string _ram;
        private string _memory;
        private string _hdd;
        private string _cpu;

        public CreatorDeveloperComputer(string cpu, string hdd, string memory, string ram)
        {
            _cpu = cpu;
            _hdd = hdd;
            _memory = memory;
            _ram = ram;
        }

        public override string getCPU()
        {
            return _cpu;
        }

        public override string getHDD()
        {
            return _hdd;
        }

        public override string getMemory()
        {
            return _memory;
        }

        public override string getRam()
        {
            return _ram;
        }
    }
}
