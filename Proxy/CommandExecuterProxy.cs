using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CommandExecuterProxy : ICommandExecuter
    {
        private bool isAdmin;
        private ICommandExecuter proxy;

        public CommandExecuterProxy(string user, string password)
        {
            if (user == "Admin" && password == "1234")
            {
                isAdmin = true;
                proxy = new CommandExecuter();
            }
        }

        public void RunCommand(string cmd)
        {
            if(isAdmin) proxy.RunCommand(cmd);
            else Console.WriteLine("This command is not allowed for non-admin users!");


        }
    }
}
