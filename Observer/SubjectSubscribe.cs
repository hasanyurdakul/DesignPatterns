using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SubjectSubscribe : IObserve
    {
        private string _name;
        private ISubject _topic;

        public SubjectSubscribe(string name)
        {
            _name = name;
        }


        public void SetSubject(ISubject subject)
        {
            _topic = subject;
        }

        public void Update()
        {
            string msg = (string)_topic.GetUpdate(this);
            if(msg == null)
            {
                Console.WriteLine($"{_name} : : No New Messages");
            }else
            {
                Console.WriteLine($"{_name} : : Consuming Messages {msg}");
            }

        }
    }
}
