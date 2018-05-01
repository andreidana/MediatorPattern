namespace MediatorExample.Mediator
{
    public abstract class Mediator
    {
        public abstract void SendMessage(string message, User user);
    }
}