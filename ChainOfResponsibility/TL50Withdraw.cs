using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class TL50Withdraw : IWithdrawChain
    {
        private IWithdrawChain _chain;

        public void setNextChain(IWithdrawChain nextChain)
        {
            _chain = nextChain;
        }

        public void withdraw(Currency cur)
        {
            if (cur.getAmount() >= 50)
            {
                int num = cur.getAmount() / 50;
                int remainder = cur.getAmount() % 50;
                Console.WriteLine($"{num} adet 50 TL verildi");
                if (remainder != 0) _chain.withdraw(new Currency(remainder));
            }
        }
    }
}
