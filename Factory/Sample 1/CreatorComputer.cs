using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Sample_1
{
    public abstract class CreatorComputer
    {
        public abstract string getRam();
        public abstract string getMemory();
        public abstract string getHDD();
        public abstract string getCPU();
        public override string ToString()
        {
            return $"RAM: {getRam()}, MEMORY: {getMemory()}, HDD: {getHDD()}, CPU:{getCPU()}";
        }
    }
}
