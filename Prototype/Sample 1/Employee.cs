using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Sample_1
{
    public class Employee : ICloneable
    {
        private List<string> _empList;
        public Employee()
        {
            _empList = new List<string>();
        }
        public Employee(List<string> emplist)
        {
            _empList = emplist;
        }
        public void LoadData()
        {
            _empList.Add("Pinar");
            _empList.Add("Ali");
            _empList.Add("Veli");
            _empList.Add("Ayse");
        }
        public List<string> GetEmployeeList()
        {
            return _empList;
        }
        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (var item in GetEmployeeList())
            {
                temp.Add(item);
            }
            return new Employee(temp);
        }
    }
}
