using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class TL100Withdraw : IWithdrawChain
    {
        private IWithdrawChain _chain;

        public void setNextChain(IWithdrawChain nextChain)
        {
            _chain = nextChain;
        }

        public void withdraw(Currency cur)
        {
            int remainder = cur.getAmount() % 100;

            if (cur.getAmount() >= 100)
            {
                int num = cur.getAmount() / 100;
                Console.WriteLine($"{num} adet 100 TL verildi");
            }

            if (remainder != 0) _chain.withdraw(new Currency(remainder));
            
        }
    }
}
