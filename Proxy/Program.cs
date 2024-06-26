using Proxy;
using System.Windows.Input;

ICommandExecuter executer = new CommandExecuterProxy("Admin", "1234");
try
{
    executer.RunCommand("DeleteAllFiles");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}
