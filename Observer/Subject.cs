using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject : ISubject
    {

        private List<IObserve> _observers;
        private string _message;
        private bool _changed;
        private object _lock = new object();

        public Subject()
        {
            _observers = new List<IObserve>();
        }


        public object GetUpdate(IObserve observer)
        {
            return _message;
        }

        public void NotifyObserver()
        {
            List<IObserve> observersLocal = null;
            lock (_lock)
            {
                if (!_changed)
                    return;
            }
            observersLocal = new List<IObserve>(_observers);
            _changed = false;
            foreach (var observer in observersLocal)
            {
                observer.Update();
            }
        }

        public void Register(IObserve observer)
        {
            if (observer == null)
            {
                throw new Exception("Observer is null");
            }
            else
            {
                lock (_lock)
                {
                    if (!_observers.Contains(observer))
                    {
                        _observers.Add(observer);
                    }
                }
            }
        }

        public void Unregister(IObserve observer)
        {
            lock (_lock)
            {
                _observers.Remove(observer);
            }

        }

        public void PostMessage(string message)
        {
            Console.WriteLine("Message posted to subject: " + message);
            _message = message;
            _changed = true;
            NotifyObserver();
        }
    }
}
