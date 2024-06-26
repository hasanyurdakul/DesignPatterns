using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<User> _users = new List<User>();

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
