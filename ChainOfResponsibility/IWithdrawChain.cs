using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IWithdrawChain
    {
        void setNextChain(IWithdrawChain nextChain);
        void withdraw(Currency cur);
    }
}
