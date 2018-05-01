namespace MediatorExample.Mediator
{
    public class ConcreteMediator: Mediator
    {
        private User1 _user1;
        private User2 _user2;

        public User1 User1
        {
            set => _user1 = value;
        }

        public User2 User2
        {
            set => _user2 = value;
        }

        public override void SendMessage(string message, User user)
        {
            if (user == _user1)
            {
                _user2.Notify(message);
            }
            else
            {
                _user1.Notify(message);
            }
        }
    }
}