using MediatorExample.Mediator;

namespace MediatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var user1 = new User1(mediator);
            var user2 = new User2(mediator);

            mediator.User1 = user1;
            mediator.User2 = user2;

            user1.SendMessage("Hello World!");
            user2.SendMessage("Why hello there!");
        }
    }
}
