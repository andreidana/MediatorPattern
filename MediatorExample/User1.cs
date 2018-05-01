using System;

namespace MediatorExample
{
    public class User1: User
    {
        public User1(Mediator.Mediator mediator) : base(mediator) {}

        public void SendMessage(string message)
        {
            Mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"User1 receives message {message}");
        }
    }
}