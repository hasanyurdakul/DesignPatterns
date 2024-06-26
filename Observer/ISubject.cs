using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        public void Register(IObserve observer);
        public void Unregister(IObserve observer);
        public void NotifyObserver();
        public Object GetUpdate(IObserve observer);
    }

    
}
