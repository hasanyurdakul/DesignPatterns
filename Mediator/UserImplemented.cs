using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class UserImplemented : User
    {
        public UserImplemented(string name, IChatMediator mediator) : base(name, mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} : Received Message : {message}");

        }

        public override void Send(string message)
        {
            Console.WriteLine($"{_name} : Sending Message : {message}");
            _mediator.SendMessage(message, this);
        }
    }
}
