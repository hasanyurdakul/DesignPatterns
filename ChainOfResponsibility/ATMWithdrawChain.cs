using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ATMWithdrawChain
    {
        public IWithdrawChain c1;

        public ATMWithdrawChain()
        {
            c1 = new TL200Withdraw();
            IWithdrawChain c2 = new TL100Withdraw();
            IWithdrawChain c3 = new TL50Withdraw();
            c1.setNextChain(c2);
            c2.setNextChain(c3);
        }

        public void withdraw(Currency cur)
        {
            c1.withdraw(cur);
        }



    }
}
