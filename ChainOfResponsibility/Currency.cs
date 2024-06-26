using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Currency
    {
        private int _amount;

        public Currency(int amount)
        {
            _amount = amount;
        }

        public int getAmount()
        {
            return _amount;
        }
    }
}
