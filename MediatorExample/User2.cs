using System;

namespace MediatorExample
{
    public class User2: User
    {
        public User2(Mediator.Mediator mediator) : base(mediator) { }

        public void SendMessage(string message)
        {
            Mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"User2 receives message {message}");
        }
    }
}