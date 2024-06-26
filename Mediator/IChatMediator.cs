namespace Mediator
{
    public interface IChatMediator 
    {
        public void SendMessage(string message, User user);
        void AddUser(User user);
    }
}