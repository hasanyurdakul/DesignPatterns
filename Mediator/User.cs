using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class User
    {
        protected IChatMediator _mediator;
        protected string _name;

        protected User(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
